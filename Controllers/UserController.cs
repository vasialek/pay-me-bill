using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using PayMe.Models;

namespace PayMe.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /user/

        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /user/uid/qwe1234df

        public ActionResult Uid(string id)
        {
            try
            {
                // Check if user is going to login through UID
                UidRepository db = new UidRepository();
                Uid uid = db.GetByUid(id);
                uid.Validate();

                // Sign out and re-login
                FormsAuthentication.SignOut();
                FormsAuthentication.SetAuthCookie(uid.Username, false);
                return Redirect("/bill/show/10001");
            } catch( Exception ex )
            {
                return Redirect("/user/notvaliduid");
            }
        }

        //
        // GET: /user/notvaliduid

        public ActionResult NotValidUid()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [Authorize]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return Redirect("/home/index");
        }

    }
}
