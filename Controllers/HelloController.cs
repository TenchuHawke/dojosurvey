using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
namespace DojoSurvey.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        [Route("Index")]
        public IActionResult Index()
        {

            return View("Index");
        }
        [HttpPostAttribute]
        [RouteAttribute("bob")]
        public IActionResult bob(string name, string location, string language, string comment)
        {

            ViewBag.name = name;
            ViewBag.location = location;
            ViewBag.language = language;
            ViewBag.comment = comment;

            return View("output");
        }
    }
}