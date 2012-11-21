using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PayMe.Models;

namespace PayMe.Controllers
{

    [Authorize]
    public class BillController : Controller
    {
        //
        // GET: /bill/show/345

        public ActionResult Show(int id)
        {
            BillRepository db = new BillRepository();
            Bill bill = db.GetById(id);
            return View(bill);
        }

    }
}
