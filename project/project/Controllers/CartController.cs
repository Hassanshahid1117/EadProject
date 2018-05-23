using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using project.Models;
namespace project.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        Mydb db = new Mydb();

        public ActionResult ShowCart()
        {
            if (Session["id"] == null)
            {
                return Redirect("~/Customer/Login");

            }
            ViewBag.ProductsList = db.products.ToList();
            var list = db.cart.ToList();
            return View(list);
        }
        public ActionResult AddtoCart(int id)
        {
            if (Session["id"] == null)
            {
                return Redirect("~/Customer/Login");
            }
            if (ModelState.IsValid)
            {

                Products find = db.products.Find(id);
                cart c = new cart();
                c.pid = find.id;
                c.cid = (int)Session["id"];
                db.cart.Add(c);
                db.SaveChanges();
                return RedirectToAction("ShowCart");
            }
            return View();
        }


        public ActionResult RemoveProduct(int id)
        {
            if (Session["id"] == null)
            {
                return Redirect("~/Customer/Login");
            }
            var del = db.cart.Find(id);
            db.cart.Remove(del);
            db.SaveChanges();
            return RedirectToAction("ShowCart");
        }



    }
}
