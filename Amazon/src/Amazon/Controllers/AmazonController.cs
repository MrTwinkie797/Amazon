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
        AmazonContext _context;
        


        ILogger<AmazonController> _logger;
        public AmazonController(ILogger<AmazonController> logger, AmazonContext context)
        {
            _logger = logger;
            _context = context;
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
            var model = new ForumsViewModel();
            model.IsLoggedIn = User.Identity.IsAuthenticated;
            return View(model);
        }
        public IActionResult Pictures()
        {
            return View();
        }
        public IActionResult Logout()
        {
            var model = new ForumsViewModel();
            model.IsLoggedIn = User.Identity.IsAuthenticated;
            return View(model);
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
        
        public IActionResult CreateComment()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateComment(CreateCommentViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);



            return RedirectToAction("ReadComments");
        }
        public IActionResult ReadComments()
        {
            return View();
        }
    }
}
