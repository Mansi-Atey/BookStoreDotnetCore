using ManagerLayer.IManager;
using Microsoft.AspNetCore.Mvc;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserManager userManager;
        public UserController(IUserManager userManager)
        {
            this.userManager = userManager;
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Login()
        {
            ViewBag.xyz = "Success";
            return View();
        }
        [HttpPost]
        public ActionResult AddUserDetails(User user)
        {
            try
            {
                var result = this.userManager.AddUserDetails(user);
                ViewBag.Message = "User registered successfully";

                return RedirectToAction("Login");
            }
            catch (Exception)
            {
                return ViewBag.Message = "Unsuccessfull";
            }
        }
        [HttpPost]
        public ActionResult Login(Login login, string ReturnUrl)
        {
            try
            {
                if (IsValid(login))
                {
                    // FormsAuthentication.SetAuthCookie(login.Email, false);
                    ViewBag.Message = "User Logged in successfully";
                    return Redirect(ReturnUrl);
                }
                else
                {
                    return View();
                }
            }
            catch (Exception)
            {
                return ViewBag.Message = "User Login unsuccessfull";
            }
        }

        public bool IsValid(Login login)
        {
            return this.userManager.Login(login);
        }

    }
}
