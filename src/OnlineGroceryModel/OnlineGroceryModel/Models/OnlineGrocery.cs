using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryModel.Models
{
	public class OnlineGrocery
	{
		// ID, ComicBookId, ComicBookID
		public int Id { get; set; }
		public string FoodName { get; set; }
		public double FoodCost { get; set; }
		public string FoodType { get; set; }
		public DateTime PublishedOn { get; set; }
		public decimal? AverageRating { get; set; } 
	}

}
