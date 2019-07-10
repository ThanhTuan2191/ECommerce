using ECom.Service;
using ECommerce.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            if(ModelState.IsValid)
            {
                var ok = new LoginService().Login(loginViewModel.Email, loginViewModel.Password);
                if (ok)
                    return RedirectToAction("Index","Home");
            }
            else
            {
                ModelState.AddModelError("", "Hello");
            }
            return View(loginViewModel);
        }
    }
}