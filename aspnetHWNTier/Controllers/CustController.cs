using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;

namespace aspnetHWNTier.Controllers
{
    public class CustController : Controller
    {
        // GET: Cust
        public ActionResult Index()
        {
            var model = GetCustomer_BLL();
            return View(model);
        }
    }
}