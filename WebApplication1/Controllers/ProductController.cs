using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        private readonly EShopDB_DNCEntities eShopDB_DNC = new EShopDB_DNCEntities();
        public ProductController()
        {

        }
        
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
    }
}