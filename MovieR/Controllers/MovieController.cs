using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieR.DAL;
using MovieR.Model;
using MySql.Data.MySqlClient;

namespace MovieR.Controllers
{
	public class MovieController : Controller
    {

		private MovieContext db;
		private Movie d;
		public MovieController()
		{
			this.db = new MovieContext();

		}

		[HttpPost]
		public ActionResult Submit(Movie mov)
		{
			db.Movies.Add(mov);
			db.SaveChanges();
			return RedirectToAction("Index", "Home");

		}

		[HttpGet]
		public ActionResult Submit()
		{
			return View();
		}

        public ActionResult Index()
        {
            return View ();
        }

        public ActionResult Details(string id)
        {
			 d = this.db.Movies.Where(x => x.MovieId == id).First();
			return View(d);
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try {
                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        }
		public Movie ReturnMovieById(string id)
		{
			return this.db.Movies.Where(x => x.MovieId == id).First();
		}

		[HttpGet]
		public ActionResult Edit(string m)
        {
		    d = this.db.Movies.Where(x => x.MovieId == m).First();
			return View(d);
        }

        [HttpPost]
		public ActionResult Edit(Movie emovie )
        {
			//update db with new values
			// return to detail page 
			db.Entry(emovie).State = EntityState.Modified;
			db.SaveChanges();
			return Redirect("ListAll");
        }

		public ActionResult DeleteAll()
        {
			db.Movies.RemoveRange(db.Movies.ToList());
			db.SaveChanges();
			return RedirectToAction("Index", "Home");

		}

		public ActionResult Delete(string id)
		{
			db.Movies.Remove((Movie)db.Movies.Where(x => x.MovieId == id).FirstOrDefault());
			db.SaveChanges();
			return Redirect("Index");

		}

		public ActionResult ListAll()
		{
			List<Movie> allMovies;
			allMovies = this.db.Movies.ToList();

			return View(allMovies); 

		}

		[HttpGet]
		public ActionResult ImportMovie()
		{
			return View();

		}

		[HttpPost]
		public ActionResult ImportMovie(string id)
		{

			return View();
		}

		[HttpGet]
		public ActionResult Search()
		{

			return View();

		}

		[HttpPost]
		public ActionResult Search(string moviename)
		{
			Console.Write("111");
			List<Movie> r = db.Movies.Where(x => x.Name.Contains(moviename)).ToList();
			//return View(db.Movies.Where(x => x.Name.Contains(moviename)).ToList());
			return View(r);
		}
	
    }
}