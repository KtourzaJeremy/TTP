using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using TrouveTonPote.Models;

namespace TrouveTonPote.Controllers
{
    public class HomeController : Controller
    {


        public ActionResult Index()
        {
            return View();
        }


        public ActionResult connexion()
        {

            return View();
        }

        public ActionResult newUser()
        {

            return View();
        }

        [HttpPost]
        public void saveNewUser(string username, string firstname, string lastname, string email, string mdp, string Genre, string Age)
        {
            Models.User us = new Models.User();

            us.userName = username;
            us.firstname = firstname;
            us.lastname = lastname;
            us.email = email;
            us.mdp = mdp;
            us.Genre = Genre;
            us.Age = Age;

            //mettre un try catch la

            us.saveUser();

        }


        [HttpGet]
        public ActionResult checkNotexistUserName(string userName)
        {
            Models.User us = new Models.User();
            var exist = us.checkuserName(userName);
            if (exist > 0)
            {

                return Json("false", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("/UserSession/AccueilUser", JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult checkUser(string username, string pswd)
        {
            Models.User us = new Models.User();
            int exist = us.checkUser(username, pswd);
            if (exist > 0)
            {
                return Json("true", JsonRequestBehavior.AllowGet);

            }
            else
            {
                return Json("false", JsonRequestBehavior.AllowGet);
            }
        }


    }
}