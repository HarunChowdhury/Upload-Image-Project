using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FileUploadExample.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Upload(HttpPostedFileBase file)
        {
            string path = Server.MapPath("~/Images/" + file.FileName);
            ViewBag.Path = "File Uploaded Successfully! Wow";
            file.SaveAs(path);
            return View();
        }
	}
}