using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartInventory.Models.Dto;
using SmartInventory.Models.Models;
using System.Reflection.Emit;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartInventory.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	[Authorize]
	public class DashBoardController : ControllerBase
	{
		private readonly demo01Context? _context;
		public DashBoardController(demo01Context? demo01Context) => _context = demo01Context;

		// GET: api/<DashBoardController>
		[HttpGet]
		public async Task<ActionResult<DashboardDto>> Get()
		{
			var data = new DashboardDto();

			data.TotalProductCount = await _context.Products.CountAsync();
			data.TotalStock = await _context.Products.SumAsync(x => Convert.ToInt32(x.Stock));
			data.TotalValue = await _context.Products.SumAsync(x => Math.Round(Convert.ToInt32(x.Stock) * (x.Price ?? 0), 2));
			data.LowStockAlertCount = await _context.Products.CountAsync(x => Convert.ToInt32(x.Stock) < 100);

			data.BarData = await _context
								.Products
								.OrderByDescending(x => Convert.ToInt32(x.Stock) * (x.Price ?? 0))
								.Take(10)
								.Select(x => new ChartDataDto
								{
									Label = x.Name,
									Value = Math.Round(((Convert.ToDouble(x.Stock) * Convert.ToDouble(x.Price ?? 0)) / 1000000), 2)
								})
								.ToListAsync();

			int lowCount = await _context.Products.CountAsync(x => Convert.ToInt32(x.Stock) < 50);

			int healthyCount = await _context.Products.CountAsync(x => Convert.ToInt32(x.Stock) >= 50 && Convert.ToInt32(x.Stock) <= 500);

			int overCount = await _context.Products.CountAsync(x => Convert.ToInt32(x.Stock) < 500);

			data.PieData =
			[
				new() { Label = "库存预警(<50)", Value = lowCount},
				new() { Label = "库存健康(50-500)", Value =  healthyCount},
				new() { Label = "库存积压(<500)", Value = overCount}
			];

			return data;
		}

		// GET api/<DashBoardController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<DashBoardController>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/<DashBoardController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<DashBoardController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
