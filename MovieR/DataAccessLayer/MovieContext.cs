using System;
using System.Data.Entity;
using MovieR.Model;
using System.Data.Common;

namespace MovieR.DAL
{
	public class MovieContext : DbContext
	{
		public MovieContext() : base("MovieContext")
		{

		}

		public MovieContext(DbConnection existingConnection, bool contextOwnsConnection) : base(existingConnection, contextOwnsConnection)
		{

		}
		public DbSet<Movie> Movies { get; set; }
		public DbSet<Comments> Comments { get; set; }


	}

}

