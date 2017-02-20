using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace TTPV2.Controllers
{
    public class HomeController : Controller
    {
      

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

   

        public ActionResult AccueilUser(Models.TTPDBEntities db )
        {
            ViewData.Model = db.Events.ToList();
            return View(db);
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
        public bool checkNotexistUserName(string userName)
        {
            Models.User us = new Models.User();
            int exist = us.checkuserName(userName);
            if (exist > 0)
            {

                return false;
            }
            else
            {
                return true;
            }
        }

        [HttpGet]
        public bool checkUser(string username, string pswd)
        {
            Models.User us = new Models.User();
            int exist = us.checkUser(username, pswd);
            if (exist !=  0)

                return true;

            else
                return false;

        }

     
    }
}