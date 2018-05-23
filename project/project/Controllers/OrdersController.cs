using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using project.Models;

namespace project.Controllers
{
    public class OrdersController : Controller
    {
        // GET: Orders
        Mydb db = new Mydb();
        public ActionResult Index()
        {

            if (Session["id"] != null)
            {
                var data = db.orders.ToList();
                ViewBag.ProductsList = db.products.ToList();
                return View(data);
            }
            return RedirectToAction("Login", "Customer");
        }
        public ActionResult placeOrder()
        {

            if (Session["id"] == null)
            {
                return Redirect("~/Customer/Login");
            }
            var cart = db.cart.ToArray();
            Orders ord = new Orders();
            for (int i = 0; i < cart.Length; i++)
            {
                ord.uis = (int)Session["id"];
                ord.pid = cart[i].pid;
                ord.status = "Pending";
                db.orders.Add(ord);
                db.SaveChanges();
                db.cart.Remove(cart[i]);
                db.SaveChanges();
            }
            return Redirect("~/Products/Index");

        }

        public ActionResult RemoveOrder(int id)
        {
            if (Session["id"] == null)
            {
                return Redirect("~/Customer/Login");
            }
            var del = db.orders.Find(id);
            db.orders.Remove(del);
            db.SaveChanges();
            Session["Cart"] = null;
            return RedirectToAction("Index");
        }


    }

}