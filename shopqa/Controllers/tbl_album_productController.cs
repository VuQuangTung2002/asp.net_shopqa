using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace shopqa.Controllers
{
    public class tbl_album_productController : Controller
    {
        private shopqa db = new shopqa();

        // GET: tbl_album_product
        public ActionResult Index()
        {
            return View(db.tbl_album_product.ToList());
        }

        // GET: tbl_album_product/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_album_product tbl_album_product = db.tbl_album_product.Find(id);
            if (tbl_album_product == null)
            {
                return HttpNotFound();
            }
            return View(tbl_album_product);
        }

        // GET: tbl_album_product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbl_album_product/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "pk_album_product_id,fk_product_id,c_img,status")] tbl_album_product tbl_album_product)
        {
            if (ModelState.IsValid)
            {
                db.tbl_album_product.Add(tbl_album_product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_album_product);
        }

        // GET: tbl_album_product/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_album_product tbl_album_product = db.tbl_album_product.Find(id);
            if (tbl_album_product == null)
            {
                return HttpNotFound();
            }
            return View(tbl_album_product);
        }

        // POST: tbl_album_product/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "pk_album_product_id,fk_product_id,c_img,status")] tbl_album_product tbl_album_product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_album_product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_album_product);
        }

        // GET: tbl_album_product/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_album_product tbl_album_product = db.tbl_album_product.Find(id);
            if (tbl_album_product == null)
            {
                return HttpNotFound();
            }
            return View(tbl_album_product);
        }

        // POST: tbl_album_product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_album_product tbl_album_product = db.tbl_album_product.Find(id);
            db.tbl_album_product.Remove(tbl_album_product);
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
