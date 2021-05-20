using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using Coffee_Shop_Redo.Models;

namespace Coffee_Shop_Redo.Controllers
{
    public class ProductController : Controller
    {
        static MySqlConnection myDB = new MySqlConnection("Server=localhost;Database=coffeehouse;Uid=root;Password=abc123");
        public IActionResult Index()
        {
            List<Product> allProd = myDB.GetAll<Product>().ToList();
            // db getall
            // pass to vewi
            return View(allProd);
        }
        public IActionResult Detail(int id)
        {
            Product aProd = myDB.Get<Product>(id);
            return View(aProd);
        }
    }
}
