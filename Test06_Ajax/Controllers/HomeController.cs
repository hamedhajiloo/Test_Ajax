using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test06_Ajax.Services;

namespace Test06_Ajax.Controllers
{
    public partial class HomeController : Controller
    {
        private readonly IAlaki _alaki;
        public HomeController(IAlaki alaki)
        {
            _alaki = alaki;
        }
        public virtual ActionResult Index()
        {
            _alaki.Add(3);
            return View();
        }

        public virtual ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public virtual ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}