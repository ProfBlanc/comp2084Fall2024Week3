using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			TempData["name"] = "C#";
			//TempData.Keep();
			return View();
		}
		public IActionResult Aboutus()
		{
			string intro = "This is the intro to our about us page";
			string moreInfo = "We are passionate about teaching. " +
				"We have the best intern programs in Northern Ontario. " +
				"We are the coolest professors";
			string outro = "You should apply now!";

			ViewData["Title"] = "About us";

			ViewData["intro"] = intro;
			ViewBag.moreInfo = moreInfo;
			ViewData["outro"] = outro;

			string name = TempData["name"] != null ? (string)TempData["name"] 
				: "no name found";

			ViewBag.name = name;
			return View();

			/*
			return View(new List<object> {
			"first",
			123,
			true
			});
			*/

		}

        public IActionResult Page1()
        {
            return Content("This is plain text content without a view file");

        }
        public IActionResult Page2()
        {
			return Redirect("/Home/Privacy");

        }
        public IActionResult Page3()
        {
			return RedirectToAction("Aboutus");

        }

        public IActionResult Page4()
        {
			return View("Privacy");

        }




        public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
