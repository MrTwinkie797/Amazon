using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Amazon.Models;
using Amazon.ViewModels;
using Microsoft.Extensions.Logging;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Amazon.Controllers
{
    public class AmazonController : Controller
    {
        ILogger<AmazonController> _logger;
        public AmazonController(ILogger<AmazonController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            _logger.LogInformation("AmazoController.index called");
            return View();
        }


        public IActionResult Store()
        {
            return View();
        }
        public IActionResult Forums()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View("~/Views/Account/Login.cshtml");
        }
        public IActionResult Register()
        {
            return View("~/Views/Account/Register.cshtml");
        }
        public IActionResult Pictures()
        {
            return View();
        }
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult Information()
        {
            var models = DataManager.GetAll();

            return View(models);
        }
    }
}
