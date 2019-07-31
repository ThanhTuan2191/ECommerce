using ECom.Service;
using ECommerce.Areas.Admin.Models;
using ECommerce.Utilities.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ECommerce.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        LoginService loginService = null;
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(LoginViewModel loginViewModel)
        {
      //      var ok = new LoginService().Login(loginViewModel.Email, loginViewModel.Password);
            if (ModelState.IsValid && Membership.ValidateUser(loginViewModel.Email,loginViewModel.Password))
            {
                FormsAuthentication.SetAuthCookie(loginViewModel.Email, loginViewModel.RememberMe);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Email or Password is incorrect");
            }
            return View(loginViewModel);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }
    }
}