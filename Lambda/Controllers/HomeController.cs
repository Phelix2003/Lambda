﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Lambda.Models;

namespace Lambda.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {


            // If the user is logged in let's tag its last activity.
            var UserManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var user = UserManager.FindById(User.Identity.GetUserId());
            if (user != null)
            {
                user.DateOfLastConnect = DateTime.Now;
                var result = UserManager.Update(user);
            //https://docs.microsoft.com/en-us/aspnet/identity/overview/extensibility/overview-of-custom-storage-providers-for-aspnet-identity#architecture


            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}