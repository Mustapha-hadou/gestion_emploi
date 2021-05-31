using miniPrpject_Asp.Models;
using miniPrpject_Asp.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace miniPrpject_Asp.Controllers
{
    public class AdminController : Controller
    {
        EmploiContext db = new EmploiContext();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Programer_Emploi()
        {
            ViewBag.semaines = new SelectList(db.Semaines, "Id", "NomSemaine");
            ViewBag.classes = new SelectList(db.Classes, "Id", "code");
            ViewBag.annees = new SelectList(db.Annees, "Id", "Nom");
            return View();
        }

        [HttpPost]
        public ActionResult Programer_emploi_etap1(int classe, int semaine, int annee)
        {
            var emploi_id = db.Emplois.Where(
                x =>
                x.IdAnnee == annee &&
                x.id_niveau == classe &&
                x.IdSemaine == semaine).First().Id;
            var detail_emploi = db.DetailEmplois.Where(x => x.IdEmploi == emploi_id).ToList();
            
            return View(detail_emploi);
        }
    }
}