using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace dockerPOC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Console.Write("qw");

            var dd = Request.Host.Value;
            var ll = dd.Split(':');
            ViewData["IpAddr"] = ll[0];
            ViewData["Port"] = ll[1];
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
