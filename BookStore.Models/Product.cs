using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
	public class Product
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Title { get; set; }
		public string Description { get; set; }
		[Required]
		public string ISBN { get; set; }
		[Required]
		public string Author { get; set; }
		[Required]
		[Display(Name ="List Price")]
		[Range(0,1000)]

		public int ListPrice { get; set; }
		[Required]
		[Display(Name ="Price for 1-50")]
		[Range(0,1000)]

		public int Price { get; set; }
		[Required]
		[Display(Name ="Price for 50+")]
		[Range(0,1000)]

		public int Price50 { get; set; }
		[Required]
		[Display(Name ="Price for 100+")]
		[Range(0,1000)]
		public int Price100 { get; set; }

	}
}
