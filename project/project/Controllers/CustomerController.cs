using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using project.Models;

namespace project.Controllers
{
    public class CustomerController : Controller
    {

        Mydb db = new Mydb();

        // GET: Customer
        public ActionResult Signup()
        {
            if (Session["id"] != null)
            {
                return Redirect("~/Products/index");
            }
            return View();

        }
        [HttpPost]
        public ActionResult Signup(customer data)
        {
            if (ModelState.IsValid)
            {
                db.customer.Add(data);
                db.SaveChanges();
                return Redirect("~/Customer/Login");
            }
            return View(data);
        }

        public ActionResult Login()
        {
            if (Session["id"] != null)
            {
                return Redirect("~/Products/index");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Login(customer data)
        {
            var c = db.customer.ToArray();

            for (int i = 0; i < c.Length; i++)
            {
                if (c[i].Username == data.Username && c[i].Password == data.Password)
                {
                    var find = db.customer.Find(c[i].id);

                    Session["id"] = c[i].id;
                    Session["Name"] = c[i].Name;
                    Session["username"] = c[i].Username;

                    return Redirect("~/Products/index");
                }
            }
            return View(data);

        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }




    }
}