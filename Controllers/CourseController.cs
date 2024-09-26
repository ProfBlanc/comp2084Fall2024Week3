using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class CourseController : Controller
    {
        private List<CourseModel> courses = new List<CourseModel>(10)
        { 
            new CourseModel(id: 1, courseCode: "comp2084", 
                courseName: "Server-Side Scripting with ASP.NET"
                ),
            new CourseModel(id: 2, courseCode: "comp1008",
                courseName: "Intro to OOP using Java"
                ),
            new CourseModel(id: 3, courseCode: "comp1011",
                courseName: "Advanced Java without Ben"
                )
        };


        // GET: CourseController
        public ActionResult Index()
        {
            ViewData["Title"] = "Courses Overview";
            ViewBag.Title = "course Overview";

            return View(courses);
        }

        // GET: CourseController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        
    }
}
