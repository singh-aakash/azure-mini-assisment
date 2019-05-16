using BankingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankingApp.Controllers
{
    public class ProductController : Controller
    {
        ProductDetails prod = new ProductDetails()
        {
            Name = "Mobile Phone",
            Category = "Electronics",
            OrderDate = DateTime.UtcNow,
            ProdQty = 2,
            Price = 10000.00
        };
        // GET: Product
        public ActionResult Edit()
        {
            return View(prod);
        }
        public ActionResult Display()
        {
            return View(prod);
        }
    }
}