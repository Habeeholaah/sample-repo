using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace STUDENTPORTAL
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        ForTestContext context = new ForTestContext();

        public HomeController(ILogger<HomeController> logger)   //DI
        {
            _logger = logger;
        }

        // To get Customer Information

        [HttpGet]
        public JsonResult GetCustomer()
        {
            var result = context.TblCustomerInformation.ToList();
            return Json(result);
        }
        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCustomer(TblCustomerInformation customer)
        {
            context.TblCustomerInformation.Add(customer);
            //Console.WriteLine(customer.Address);
            context.SaveChanges();
            return View();
        }
        public IActionResult Index()
        {

            return View();
        }

        //[HttpPost]
        //public IActionResult Index(string FirstName)   //HttpPost is accepting parameter from the user
        //{
        //    return View();
        //}

        public IActionResult About()
        {
            return View();
        }


    }
}
