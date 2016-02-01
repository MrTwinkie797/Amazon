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
    public class HomeController : Controller
    { 
        public IActionResult GetPartialView(int id)
        {
            var models = DataManager.GetAll();
            EngineBoxViewModel model = new EngineBoxViewModel();

            foreach (var item in models)
            {
                if (item.Id == id)
                {
                    model.Type = item.Type;
                    model.Bhp = item.Bhp;
                    model.Litre = item.Litre;
                    model.TopSpeed = item.TopSpeed;
                    model.Info = item.Info;
                }
            }

            return PartialView("_EngineBox", model);
        }



        public IActionResult JsonCars()
        {
            var models = DataManager.GetAll();

            return Json(models);
        }
        

    }
}
