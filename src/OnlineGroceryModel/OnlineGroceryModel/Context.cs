using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineGroceryModel.Models;

namespace OnlineGroceryModel
{
	public class Context : DbContext
	{
		public DbSet<OnlineGrocery> OnlineGroceries { get; set; }
	}
}

