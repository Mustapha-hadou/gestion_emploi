using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using miniPrpject_Asp.Models;
using miniPrpject_Asp.Models.Data;

namespace miniPrpject_Asp.Controllers
{
    public class LocalsController : Controller
    {
        private EmploiContext db = new EmploiContext();


        public ActionResult List()
        {
            return View("List", db.Locals.ToList());
        }




        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,TypeLocal,Capacite,Nom,localisation")] Local local)
        {
            if (ModelState.IsValid)
            {
                db.Locals.Add(local);
                db.SaveChanges();
                return RedirectToAction("List");
            }

            return View(local);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Local local = db.Locals.Find(id);
            if (local == null)
            {
                return HttpNotFound();
            }
            return View(local);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,TypeLocal,Capacite,Nom,localisation")] Local local)
        {
            if (ModelState.IsValid)
            {
                db.Entry(local).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("List");
            }
            return View(local);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Local local = db.Locals.Find(id);
            if (local == null)
            {
                return HttpNotFound();
            }
            return View(local);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Local local = db.Locals.Find(id);
            db.Locals.Remove(local);
            db.SaveChanges();
            return RedirectToAction("List");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
