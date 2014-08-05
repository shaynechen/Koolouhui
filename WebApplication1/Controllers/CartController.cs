using Koo.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Koo.Web.Controllers
{
    public class CartController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        //
        // GET: /Cart/
        public ActionResult Index()
        {
            List<CartItem> items = new List<CartItem>();

            if (HttpContext.Session["CurrentCart"] != null)
            {
                items = (List<CartItem>)HttpContext.Session["CurrentCart"];
            }

            foreach (var item in items)
            {
                item.Project = db.Projects.Find(item.ProjectId);
            }

            return View(items);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}