using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartInventory.Models.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartInventory.API.Controllers
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly demo01Context? _demo01Context;
		public ProductController(demo01Context? demo01Context) => _demo01Context = demo01Context;

		// GET: api/<ProductController>
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Product>>> Get()
		{
			return await _demo01Context.Products.ToListAsync();
		}

		// GET api/<ProductController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<ProductController>
		[HttpPost]
		public async Task<IActionResult> Post([FromBody] Product product)
		{
			try
			{
				_demo01Context?.Products.Add(product);
				await _demo01Context.SaveChangesAsync();
				return Ok();
			}
			catch (Exception e)
			{
				return BadRequest(e.ToString());
				// 记录log
			}
		}

		// PUT api/<ProductController>/5
		[HttpPut("{id}")]
		public async Task<ActionResult<IEnumerable<Product>>> Put(int id, [FromBody] Product product)
		{
			try
			{
				_demo01Context
					.Products
					.Update(product);
				await _demo01Context.SaveChangesAsync();
				return Ok();
			}
			catch (Exception e)
			{
				return BadRequest(e.ToString());

			}
		}

		// DELETE api/<ProductController>/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> Delete(int id)
		{
			try
			{
				// 硬删除
				// await _demo01Context.Products.Where(x => x.Id == id).ExecuteDeleteAsync();

				// 软删除
				await _demo01Context.Products.Where(x => x.Id == id).ExecuteUpdateAsync(y => y.SetProperty(z => z.IsDeleted, true));
				return Ok();
			}
			catch (Exception e)
			{

				return BadRequest(e.ToString());
			}
		}
	}
}
