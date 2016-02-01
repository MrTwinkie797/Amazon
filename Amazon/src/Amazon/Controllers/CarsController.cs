using CarsApp.Models;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;


// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Amazon.Controllers
{
    [Route("api/[controller]")]
    public class CarsController : ApiController
    {
        Car[] cars = new Car[]
        {
                new Car {Id = 1, License = "RSX746", Brand = "Volvo", Model = "V70" },
                new Car {Id = 2, License = "URH748", Brand = "Toyota", Model = "Avensis" },
                new Car {Id = 3, License = "DRO962", Brand = "VW", Model = "Golf" },
                new Car {Id = 4, License = "URH748", Brand = "Saab", Model = "9-3" },
                new Car {Id = 5, License = "MAE648", Brand = "Volvo", Model = "760" },
                new Car {Id = 6, License = "SEL732", Brand = "BMW", Model = "520" },
                new Car {Id = 7, License = "ASP947", Brand = "Volvo", Model = "XC70" },

        };

        public IEnumerable<Car> GetAllCar()
        {
            return cars;
        }

        //GET: api/cars/license
        [HttpGet("{license}")]
        public Car Get(string license)
        {
            foreach (var car in cars)
            {
                if (car.License == license)
                {
                    return car;
                }
            }
            return null;
        }
        




        //// GET: api/values
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}


        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
