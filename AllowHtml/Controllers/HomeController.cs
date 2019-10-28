using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AllowHtml.Models;

namespace AllowHtml.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new Model
            {
                htmlString = "<strong>Hello World</strong>"
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(Model model)
        {
            return View(model);
        }
    }
}