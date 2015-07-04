using CRUDMORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUDMORE.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            using(CRUDDataEntities db=new CRUDDataEntities())
            {
                ViewBag.Users=db.Logins.ToList();
            }
            return View();
        }
        [HttpGet]
        public ActionResult Add()
        {

            return View(new LoginViewModel());
        }
        [HttpPost]
        public ActionResult Add(LoginViewModel model)
        {
            if(ModelState.IsValid)
            {
               using(CRUDDataEntities db=new CRUDDataEntities())
               {
                   var Search = db.Logins.Where(m => m.UserName == model.UserName).FirstOrDefault();
                   if(Search==null)
                   {
                       db.Logins.Add(new Login
                       {
                           UserName = model.UserName,
                           Hobby1 = model.Hobby1,
                           Hobby2 = model.Hobby2,
                           Hobby3 = model.Hobby3,
                           Gender = model.Gender,
                           CityId = model.CityId,

                       });
                       db.SaveChanges();
                       ViewBag.Message = "Registrated";
                   }
                   else
                   {
                       ViewBag.Message = "Not Registrated";
                   }
               }
            }
            else
            {
                ViewBag.Message = "Fill The Required Fields";
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return RedirectToAction("Add");
            using(CRUDDataEntities db=new CRUDDataEntities())
            {
                var search = db.Logins.Where(x => x.UserId == id.Value).FirstOrDefault();
                if(search==null)
                {
                    return RedirectToAction("Add");
                }
                else
                {
                    LoginViewModel model = new LoginViewModel()
                    {
                        CityId = search.CityId,
                        Gender = search.Gender,
                        Hobby1 = search.Hobby1,
                        Hobby2 = search.Hobby2,
                        Hobby3 = search.Hobby3,
                        UserName = search.UserName,
                        UserId = search.UserId
                    };
                    return View(model);
                }

            }
          
            
        }
        [HttpPost]
        public ActionResult Edit(LoginViewModel model)
        {
            
           if(ModelState.IsValid)
           {
              using(CRUDDataEntities db=new CRUDDataEntities())
              {
                  var Search = db.Logins.Where(x => x.UserId == model.UserId).FirstOrDefault();
                  if(Search==null)
                  {
                      ViewBag.Message = "Cant Updated";
                  }
                  else
                  {
                     Search.CityId=model.CityId;
                     Search.Gender=model.Gender;
                      Search.Hobby1=model.Hobby1;
                      Search.Hobby2 = model.Hobby2;
                      Search.Hobby3 = model.Hobby3;
                      Search.UserId = model.UserId;
                      Search.UserName = model.UserName;
                      db.SaveChanges();
                      ViewBag.Message = "Data Updated";
                      return View(model);
                  }
              }
           }
            else
           {
               ViewBag.Message = "Required Field  check";
           }
           return View(model);
        }
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return RedirectToAction("Index");
            using(CRUDDataEntities db=new CRUDDataEntities())
            {
                var Search = db.Logins.Where(x => x.UserId == id.Value).FirstOrDefault();
                if(Search==null)
                {
                    ViewBag.Message = "Cant Deleted";
                }
                else
                {
                    LoginViewModel model = new LoginViewModel()
                    {
                        CityId = Search.CityId,
                        Gender = Search.Gender,
                        Hobby1 = Search.Hobby1,
                        Hobby2 = Search.Hobby2,
                        Hobby3 = Search.Hobby3,
                        UserId = Search.UserId,
                        UserName = Search.UserName,
                    };
                    return View(model);
                }
            }
            return View();
        }
        [HttpPost]
        public ActionResult Delete(LoginViewModel model)
        {
            using (CRUDDataEntities db = new CRUDDataEntities())
            {
                var Search = db.Logins.Where(x => x.UserId == model.UserId).FirstOrDefault();
                if(Search==null)
                {
                    ViewBag.Message = "Cant Deleted";
                }
                else
                {
                    db.Logins.Remove(Search);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View();
        }

    }
}