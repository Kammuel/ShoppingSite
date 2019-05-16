using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoppingSite.Models
{
	public class Item
	{
		[Key]
		public int ItemID { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public string Brand { get; set; }

		[Required]
		public string Category { get; set; }

		[Required]
		public double Price { get; set; }


	}
}