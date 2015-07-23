using AuThentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace AuThentication.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private LogindbEntities db = new LogindbEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View(new RegisterViewModel());
        }
        [HttpPost]
        public ActionResult Register(RegisterViewModel model)
        {
            if(ModelState.IsValid)
            {
                var search = db.Logins.Where(x => x.UserMail == model.UserMail).FirstOrDefault();
                 if(search!=null)
                 {
                     ViewBag.Message = "Try Another Mail Id";
                 }
                else
                 {
                     var plainPass = model.UserPass;
                     var hashPass = Crypto.HashPassword(plainPass);
                     db.Logins.Add(new Login
                     {
                         UserMail = model.UserMail,
                         UserPass = hashPass,
                         DateCreated = DateTime.Now,
                         IsActive = true,
                         RoleId = 2,
                         IsDeleted = false,

                     });
                     db.SaveChanges();
                     ViewBag.Message = "Registrated";
                 }
            }
            else
            {
                ViewBag.Message="Fill The Required Fields";
            }
            return View(model);
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View(new LoginViewModel());
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if(ModelState.IsValid)
            {
                var search = db.Logins.FirstOrDefault(x => x.UserMail == model.UserMail && x.IsDeleted != true);
                if(search!=null)
                {
                    try{
                        if(System.Web.Helpers.Crypto.VerifyHashedPassword(search.UserPass,model.UserPass))
                        {
                            HttpCookie c1 = new HttpCookie("User", model.UserMail);
                            c1.Path = "/";
                            if (model.RememberMe)
                            {
                                c1.Expires = DateTime.Now.AddDays(15);
                            }
                            Response.Cookies.Add(c1);
                             SessionWrapper.UserName = search.UserMail;
                             SessionWrapper.UserRole = search.Role.RoleName;
                             SessionWrapper.UserId = search.LoginId;
                             search.DateLastLogin = DateTime.Now;
                             db.SaveChanges();
                           

                            switch(search.RoleId)
                            {
                                case 1: return Redirect("~/Admin/Dashboard");
                                case 2: return Redirect("~/Faculty/Dashboard");
                                case 3: return Redirect("~/Student/Dashboard");
                            }
                        }
                        else
                        {
                            ViewBag.Message = "Usr/Pswd Does Not Match";
                        }

                    }
                    catch(Exception e)
                    {
                       
                    }
                    
                   
                }
                else
                {
                    ViewBag.Message = "Check Your Id and Pass";
                }
            }
            else
            {
                ViewBag.Message = "Mail id and Pass Does Not Match";
            }
            return View(model);
        }
    }
}