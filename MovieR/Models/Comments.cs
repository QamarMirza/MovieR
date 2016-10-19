using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieR.Model
{
	[Table("Comments")]
	public class Comments
	{
		
		public string MovieId { get; set; }
		public string Name { get; set; }
		public DateTime DateCreated { get; set; }
		public string Comment { get; set; }
		public int rating { get; set; }
		[Key]
		public int Id { get; set; }

	}
}

