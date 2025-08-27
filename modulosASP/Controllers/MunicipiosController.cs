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
    public class MunicipiosController : Controller
    {
        private SEICEntities db = new SEICEntities();

        // GET: Municipios
        public ActionResult Index()
        {
            var c_Municipios = db.C_Municipios.Include(c => c.C_Estado);
            return View(c_Municipios.ToList());
        }

        // GET: Municipios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C_Municipios c_Municipios = db.C_Municipios.Find(id);
            if (c_Municipios == null)
            {
                return HttpNotFound();
            }
            return View(c_Municipios);
        }

        // GET: Municipios/Create
        public ActionResult Create()
        {
            ViewBag.Id_Estado = new SelectList(db.C_Estado, "Id", "Estado");
            return View();
        }

        // POST: Municipios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Id_Estado,Municipio")] C_Municipios c_Municipios)
        {
            if (ModelState.IsValid)
            {
                db.C_Municipios.Add(c_Municipios);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Id_Estado = new SelectList(db.C_Estado, "Id", "Estado", c_Municipios.Id_Estado);
            return View(c_Municipios);
        }

        // GET: Municipios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C_Municipios c_Municipios = db.C_Municipios.Find(id);
            if (c_Municipios == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id_Estado = new SelectList(db.C_Estado, "Id", "Estado", c_Municipios.Id_Estado);
            return View(c_Municipios);
        }

        // POST: Municipios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Id_Estado,Municipio")] C_Municipios c_Municipios)
        {
            if (ModelState.IsValid)
            {
                db.Entry(c_Municipios).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id_Estado = new SelectList(db.C_Estado, "Id", "Estado", c_Municipios.Id_Estado);
            return View(c_Municipios);
        }

        // GET: Municipios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C_Municipios c_Municipios = db.C_Municipios.Find(id);
            if (c_Municipios == null)
            {
                return HttpNotFound();
            }
            return View(c_Municipios);
        }

        // POST: Municipios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            C_Municipios c_Municipios = db.C_Municipios.Find(id);
            db.C_Municipios.Remove(c_Municipios);
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
