using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace ApplicationLifeTime.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class HomeController : ControllerBase
	{
		private readonly IHostApplicationLifetime _applicationLifetime;

		public HomeController(IHostApplicationLifetime applicationLifetime)
		{
			_applicationLifetime = applicationLifetime;
		}

		[HttpGet]
		public IActionResult Get()
		{
			_applicationLifetime.StopApplication();

			return Ok("Endpoint worked...");
		}
	}
}
