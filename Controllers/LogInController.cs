using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace database.Controllers
{
    public class LogInController : Controller
    {
        // GET: LogIn
        public ActionResult login()
        {
            return View();
        }      
        
    }
}