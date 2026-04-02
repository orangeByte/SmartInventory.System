using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartInventory.Models.Dto
{
	public class ScanLog
	{
		public DateTime Time {  get; set; }
		public string SN {  get; set; }
		public string ProductName { get; set; }
		public string Status { get; set; }
	}

}
