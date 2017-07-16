using Demo.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [Route("Home")]
        [Route("")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("NewSession")]
        public ActionResult LogOut()
        {
            try
            {
                if (Session["Token"] != null)
                {
                    string result = CommonCL.Instance().Logout();
                }
            }

            catch (Exception ex)
            {

            }
            return RedirectToAction("Index", "Home");
        }
    }
}