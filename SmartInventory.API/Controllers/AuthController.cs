using BCrypt.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartInventory.Models.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SmartInventory.Models.Dto;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartInventory.API.Controllers
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class AuthController : ControllerBase
	{
		private readonly demo01Context _demo01Context;
		private readonly IConfiguration _config;

		public AuthController(demo01Context context, IConfiguration configuration)
		{
			_demo01Context = context;
			_config = configuration;
		}

		// GET: api/<AuthController>
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/<AuthController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<AuthController>
		[HttpPost]
		[AllowAnonymous]
		public async Task<IActionResult> Post([FromBody] LoginRequestDto loginDto)
		{
			var user = _demo01Context.Users.FirstOrDefault(x => x.Username == loginDto.Username && x.IsActive);
			if (user == null) return Unauthorized("用户名或密码错误");

			bool isValid = BCrypt.Net.BCrypt.Verify(loginDto.Password, user.PasswordHash);
			if (!isValid) return Unauthorized("用户名或密码错误");

			string token = GenerateJwtToken(user);

			await _demo01Context.Users.Where(x => x.Id == user.Id).ExecuteUpdateAsync(x => x.SetProperty(x => x.LastLoginTime, DateTime.Now));
			return Ok(new { token = token, username = user.Username, role = user.Role});
		}

		// PUT api/<AuthController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<AuthController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}

		[HttpPost("register")]
		[AllowAnonymous]
		public async Task<IActionResult> Register([FromBody] LoginRequestDto loginDto)
		{
			if (await _demo01Context.Users.AnyAsync(x => x.Username == loginDto.Username))
				return BadRequest("用户名已存在");

			string hash = BCrypt.Net.BCrypt.HashPassword(loginDto.Password);

			var user = new User
			{
				Username = loginDto.Username,
				PasswordHash = hash,
				Role = "user",
				IsActive = true
			};

			_demo01Context.Users.Add(user);
			await _demo01Context.SaveChangesAsync();

			return Ok("注册成功");
		}

		private string GenerateJwtToken(User user)
		{
			var claims = new[]
			{
				new Claim(JwtRegisteredClaimNames.Sub, user.Username),
				new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
				new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
				new Claim(ClaimTypes.Role, user.Role ?? "user"),
				new Claim("Dept", "IT")
			};

			var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));

			var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

			var expires = DateTime.Now.AddHours(2);

			var tokenDescriptor = new JwtSecurityToken(
				issuer: _config["Jwt:Issuer"],
				audience: _config["Jwt:Audience"],
				claims: claims,
				expires: expires,
				signingCredentials: creds
			);

			return new JwtSecurityTokenHandler().WriteToken(tokenDescriptor);
		}
	}
}
