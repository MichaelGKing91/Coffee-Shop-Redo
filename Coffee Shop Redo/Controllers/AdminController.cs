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
    public class AdminController : Controller
    {
        static MySqlConnection myDB = new MySqlConnection("Server=localhost;Database=coffeehouse;Uid=root;Password=abc123");
        public IActionResult Index()
        {
            List<Product> allProds = myDB.GetAll<Product>().ToList();
            return View(allProds);
        }

        public IActionResult Edit(int id)
        {

            Product aProd = myDB.Get<Product>(id);
            return View(aProd);
        }

        public IActionResult RecieveEditInfo(Product aProd)
        {
            myDB.Update(aProd);
            return RedirectToAction("Index");
        }

        public IActionResult AddForm()
        {
            //myDB.Insert(aProd);
            return View();
        }
        public IActionResult Add(Product aProd)
        {
            myDB.Insert(aProd);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(Product aProd)
        {
            myDB.Delete(aProd);
            return RedirectToAction("Index");
        }


    }
}
