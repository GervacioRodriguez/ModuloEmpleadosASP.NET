using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using modulosASP.Models;

namespace modulosASP.Controllers
{
    /*LLamar todos los datos en formato Json
     * para asi poder revisar los datos que sean asincronos
     */
    public class ServicioController : Controller
    {
        private SEICEntities db = new SEICEntities();

        // GET: Servicio
        public ActionResult Index()
        {
            return View(db.C_Servicio.ToList());
        }

        // GET: Servicio/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C_Servicio c_Servicio = db.C_Servicio.Find(id);
            if (c_Servicio == null)
            {
                return HttpNotFound();
            }
            return View(c_Servicio);
        }

        // GET: Servicio/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Servicio/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Proyecto,Servicio,Subproyecto,Estado,Municipio,Vence")] C_Servicio c_Servicio)
        {
            if (ModelState.IsValid)
            {
                db.C_Servicio.Add(c_Servicio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(c_Servicio);
        }

        // GET: Servicio/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C_Servicio c_Servicio = db.C_Servicio.Find(id);
            if (c_Servicio == null)
            {
                return HttpNotFound();
            }
            return View(c_Servicio);
        }

        // POST: Servicio/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Proyecto,Servicio,Subproyecto,Estado,Municipio,Vence")] C_Servicio c_Servicio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(c_Servicio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(c_Servicio);
        }

        // GET: Servicio/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C_Servicio c_Servicio = db.C_Servicio.Find(id);
            if (c_Servicio == null)
            {
                return HttpNotFound();
            }
            return View(c_Servicio);
        }

        // POST: Servicio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            C_Servicio c_Servicio = db.C_Servicio.Find(id);
            db.C_Servicio.Remove(c_Servicio);
            db.SaveChanges();
            return RedirectToAction("Index");
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
