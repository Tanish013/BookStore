using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookWala.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            var obj = new { Id = 1, nameof = "Kd" };
            return View(obj);
        }
        public ViewResult AboutUs()
        {
            return View();
        }
        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
