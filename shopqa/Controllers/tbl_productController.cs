using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace shopqa.Controllers
{
    public class tbl_productController : Controller
    {
        private shopqa db = new shopqa();

        // GET: tbl_product
        public ActionResult Index(int ?page)
        {
            var pt = db.tbl_product.Select(s=>s);
            pt = pt.OrderBy(s => s.c_name);
            int pagelist = 4;
            int pagenumber = (page ?? 1);
            return View(pt.ToPagedList(pagenumber,pagelist));
        }
        public ActionResult chuyentrang(int id)

        {
            var product = db.tbl_product.Find(id);
            if (product!= null)
            {
                ViewBag.Product = product;
                ViewBag.gioitinh = product.c_sex;
                ViewBag.name = product.c_name;
                ViewBag.gia = product.c_price;
                ViewBag.mota = product.c_noidung;
                ViewBag.thuonghieu = product.c_description;
                ViewBag.color = product.c_color;
                ViewBag.chatlieu = product.c_chatlieu;
                ViewBag.nguongoc = product.c_nguongoc;
                ViewBag.hinhanh = product.c_img;
                ViewBag.ngaytao = product.c_date_created;
                ViewBag.masp = product.c_masp;
                ViewBag.id = product.pk_product_id;
                return View();
            }


            return RedirectToAction("Index");
        }
        // GET: tbl_product/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_product tbl_product = db.tbl_product.Find(id);
            if (tbl_product == null)
            {
                return HttpNotFound();
            }
            return View(tbl_product);
        }

        // GET: tbl_product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbl_product/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "pk_product_id,fk_category_product_id,c_masp,c_name,c_description,c_color,c_chatlieu,c_noidung,c_nguongoc,c_img,c_price,c_date_created,c_sex,c_sanphamnoibat,total")] tbl_product tbl_product)
        {
            if (ModelState.IsValid)
            {
                db.tbl_product.Add(tbl_product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_product);
        }

        // GET: tbl_product/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_product tbl_product = db.tbl_product.Find(id);
            if (tbl_product == null)
            {
                return HttpNotFound();
            }
            return View(tbl_product);
        }

        // POST: tbl_product/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "pk_product_id,fk_category_product_id,c_masp,c_name,c_description,c_color,c_chatlieu,c_noidung,c_nguongoc,c_img,c_price,c_date_created,c_sex,c_sanphamnoibat,total")] tbl_product tbl_product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_product);
        }

        // GET: tbl_product/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_product tbl_product = db.tbl_product.Find(id);
            if (tbl_product == null)
            {
                return HttpNotFound();
            }
            return View(tbl_product);
        }

        // POST: tbl_product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_product tbl_product = db.tbl_product.Find(id);
            db.tbl_product.Remove(tbl_product);
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
