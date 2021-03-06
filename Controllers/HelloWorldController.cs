using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            // return "Index"; // return only string
            return View();

        }

        //
        // GET: /HelloWorld/Welcome/

        // public string Welcome()
        // {
        //     return "WELL";
        // }

        // GET: /HelloWorld/Welcome?name=Rick&numtimes=4
        // Requires using System.Text.Encodings.Web;
        public IActionResult Welcome(string name = "name", int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }


        // GET: /HelloWorld/Welcome/3?name=Rick
        // public string Welcome(string name, int ID = 1)
        // {
        //     return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        // }
    }
}