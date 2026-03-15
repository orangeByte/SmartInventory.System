using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartInventory.Models.Models
{
	public partial class demo01Context
	{
		partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>(x =>
			{
				x.HasQueryFilter(y => (bool)!y.IsDeleted);
			});
		}
	}
}
