using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categoris
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(string CategoryName)
        {
            ViewBag.CategoryName = CategoryName;
            return View();
        }

        
    }
}