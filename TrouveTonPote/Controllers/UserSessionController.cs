using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrouveTonPote.Controllers
{
    public class UserSessionController : Controller
    {

        public ActionResult AccueilUser()
        {

            return View();
        }


        [HttpPost]
        public void newEvent(string titre, string localisation, string date, string etat, string nbMax, string photo)
        {
            Models.Event evt = new Models.Event();

            evt.titre = titre;
            evt.localisation = localisation;
            evt.date = date;
            evt.etat = etat;
            evt.nbMax = nbMax;
            evt.photo = photo;

            evt.saveNewEvent();

        }

        [HttpGet]
        public ActionResult ListEvent()
        {
            List<string> lsev = new List<string>();
            Models.Event ev = new Models.Event();
            lsev = ev.showAllEvent();
            return Json(lsev, JsonRequestBehavior.AllowGet);
        }

    }
}
