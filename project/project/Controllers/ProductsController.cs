using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using project.Models;

namespace project.Controllers
{
    public class ProductsController : Controller
    {
        Mydb db = new Mydb();
        public ActionResult Index()
        {
            if (Session["id"] == null)
            {
                return Redirect("~/Customer/Login");

            }
            var product = db.products.ToList();
            return View(product);
        }



        // GET: Customer
        public ActionResult AddProducts()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProducts(Products pro)
        {
            if (ModelState.IsValid)
            {

                db.products.Add(pro);
                db.SaveChanges();
                return Redirect("~/Admin/index");
            }

            return View(pro);
        }



    }
}