using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealEstate.Controllers
{
    public class UserController : Controller
    {
        realestatesystemEntities db = new realestatesystemEntities();
        public ActionResult Index ()
        {
            return View(db.USERS.ToList());
        }
        
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create (USER newUser)
        {
            if (ModelState.IsValid)
            {
                db.USERS.Add(newUser);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(newUser);
        }
    }
}