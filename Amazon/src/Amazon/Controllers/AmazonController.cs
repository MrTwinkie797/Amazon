using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Amazon.Models;
using Amazon.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Amazon.Controllers
{
    public class AmazonController : Controller
    {
        public IActionResult Store()
        {
            return View("Store");
        }
        public IActionResult Forums()
        {
            return View("Forums");
        }
        public IActionResult Pictures()
        {
            return View("Pictures");
        }
        public IActionResult Home()
        {
            return View("Home");
        }
        public IActionResult Information()
        {
            var models = DataManager.GetAll();

            return View(models);
        }
    }
}
