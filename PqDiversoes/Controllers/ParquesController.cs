using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using PqDiversoes.Models;

namespace PqDiversoes.Controllers
{
    [Authorize]
    public class ParquesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        
        // GET: Parques
        public ActionResult Index()

        {
            return View(db.Parques.Where(x=> x.Username.Equals(User.Identity.Name)).ToList());
        }

        // GET: Parques/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Parque parque = db.Parques.Find(id);
            if (parque == null)
            {
                return HttpNotFound();
            }
            return View(parque);
        }

        // GET: Parques/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Parques/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,nomeFantasia,razaoSocial,cnpj,qtdBrinquedos")] Parque parque)
        {
            if (ModelState.IsValid)
            {
                parque.Username = User.Identity.Name;
                db.Parques.Add(parque);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(parque);
        }

        // GET: Parques/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Parque parque = db.Parques.Find(id);
            if (parque == null)
            {
                return HttpNotFound();
            }
            return View(parque);
        }

        // POST: Parques/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,nomeFantasia,razaoSocial,cnpj,qtdBrinquedos")] Parque parque)
        {
            if (ModelState.IsValid)
            {
                db.Entry(parque).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(parque);
        }

        // GET: Parques/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Parque parque = db.Parques.Find(id);
            if (parque == null)
            {
                return HttpNotFound();
            }
            return View(parque);
        }

        // POST: Parques/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Parque parque = db.Parques.Find(id);
            db.Parques.Remove(parque);
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
