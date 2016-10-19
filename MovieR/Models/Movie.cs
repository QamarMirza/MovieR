using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieR.Model
{
	[Table("MovieAccount")]
	public class Movie
	{

		public string Name { get; set; }
		[DisplayName("Poster")]

		public string imgURL { get; set; }

		public string Rating { get; set; }
		public DateTime ? DateCreated { get; set;}

		public IEnumerable<Comments> Comments { get; set; }

		//[RegularExpression(@"\d{6,10}", ErrorMessage = "Account # must be between 6 and 10 digits.")]
		[Key]
		[DisplayName("Movie Identification")]
		public string MovieId { get; set; }


		/* 
		 * public void RecalulateRating()
		{
			// for each comment, add the rating and then divide by total comments
		}
		*/
	}
}


