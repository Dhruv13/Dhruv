using AjexCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjexCRUD.Controllers
{
    public class HomeController : Controller
    {
        private AjexDbEntities db = new AjexDbEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View(new CategoryModel());
        }
        [HttpPost]
        public ActionResult Add(CategoryModel model)
        {
            if(ModelState.IsValid)
            {
                var Search = db.Products.FirstOrDefault(x => x.ProductName == model.ProductName);
                if(Search==null)
                {
                    db.Products.Add(new Product
                    {
                        
                        ProductName = model.ProductName
                    });
                    db.SaveChanges();
                    ViewBag.Message = "Success";
                }
                else
                {
                    ViewBag.Message = "Not";
                }
            }
            return View();
        }
       
    }
}