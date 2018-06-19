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
		public Context() : base("OnlineGrocery")
		{
			Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());
			// Database.SetInitializer(new CreateDatabaseIfNotExists<Context>());
			// Database.SetInitializer(new DropCreateDatabaseAlways<Context>());
		}
		public DbSet<OnlineGrocery> OnlineGroceries { get; set; }
	}
	
}

