using DocSearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DocSearch.Controllers
{
    public class HomeController : Controller
    {
        static private WASEntities _db = new WASEntities();

        public ActionResult Index()
        {
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

        [HttpPost]
        public PartialViewResult publicDetails() {

            System.Threading.Thread.Sleep(500);
            string insertedPolicyNumber = Request.Form["policyNumber"];

            //IQueryable<tbl_Folder> publicObject = _db.tbl_Folder.Where(p => p.Number == 568801);
            tbl_Folder publicObject = _db.tbl_Folder.Where(p => p.Number == 568801).FirstOrDefault();
            //568801

            tbl_Folder folder = new tbl_Folder();
            //folder.Name = "Jackie Cheng";

            return PartialView("_publicDetails", publicObject);
            //return PartialView("_publicDetails", folder);
            //return PartialView("_Test", insertedPolicyNumber);
        }
    }
}