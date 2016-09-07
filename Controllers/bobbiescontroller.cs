using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MyWebApp.Controllers
{
    public class BoobiesController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            @ViewData["Title"] = "Cholo";
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome(string name, int numTimes)
        {
            ViewData["Greeting"] = "Hello" + name;
            ViewData["numTimes"] = numTimes;
            return View();
            //return HtmlEncoder.Default.Encode($"Hello {name}, numTimes: {numTimes}");
        }
    }
}