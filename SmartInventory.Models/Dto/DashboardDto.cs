using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartInventory.Models.Dto
{

	public class DashboardDto
	{
		public int TotalProductCount {  get; set; }
		public int TotalStock { get; set; }
		public decimal TotalValue { get; set; }
		public int LowStockAlertCount { get; set; }

		public List<ChartDataDto> PieData { get; set; }
		
		public List<ChartDataDto> BarData { get; set; }


	}

	public class ChartDataDto
	{
		public string Label { get; set; }
		public double Value { get; set; }
	}
}
