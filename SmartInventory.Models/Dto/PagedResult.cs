using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartInventory.Models.Dto
{
	internal class PagedResult
	{
	}

	public class PagedResult<T>
	{
		public List<T> Items { get; set; } = [];

		public int TotalCount { get; set; }
		public int PageSize { get; set; }
		public int PageIndex { get; set; }

		public int TotalPages => (int)(Math.Ceiling((double)TotalCount / PageSize));

		public bool HasPre => PageIndex > 1;
		public bool HasNext => PageIndex < TotalPages;
	}
}
