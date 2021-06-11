using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey
{
    public class HomeController : Controller 
    {
        //localhost:5000
        [HttpGet("")]
        public ViewResult Index()
        {
            

            return View("Index");
        }

        [HttpPost("/result")]
        public IActionResult Show(string name, string location, string language, string comment)
        {
            if (name == null )
            {
                return RedirectToAction("Index");
            }

            ViewBag.Name = name;
            ViewBag.Location = location;
            ViewBag.Language = language;
            ViewBag.Comment = comment;
            return View("Show");
        }
    }
}