using Coffee_Shop_Redo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Coffee_Shop_Redo.Controllers
{
    public class HomeController : Controller
    {
        static MySqlConnection myDB = new MySqlConnection("Server=localhost;Database=coffeehouse;Uid=root;Password=abc123");
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult RegistrationForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddUser(User user)
        {
            // Add Password Validation
            if (user.password != user.passcheck)
            {
                return Content("Your passwords did not match!" +
                    " Your profile has not been created.");
            }

            Regex myRegex = new Regex(@"^\w{1,36}@\w{1,36}\.\w{2,36}$");
            if (!myRegex.IsMatch(user.email))
            {
                return Content("Your email was invalid!" +
                    " Your profile has not been created.");
            }

            myRegex = new Regex(@"^[0-9]{1,2}\([0-9]{3}\)[0-9]{3}-[0-9]{4}$");
            if (!myRegex.IsMatch(user.phone))
            {
                return Content("Your phone number was invalid!" +
                    " \nYour profile has not been created. \nPlease use the format: #(###)###-#### ");
            }
            return View(user);
        }


            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
