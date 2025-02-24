﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Shop_watch.Models;

namespace Shop_watch.Areas.NhanVien.Controllers
{
    public class San_phamController : Controller
    {
        private Shop_watchEntities db = new Shop_watchEntities();

        // GET: NhanVien/San_pham
        public ActionResult Index()
        {
            return View(db.San_pham.ToList());
        }

        // GET: NhanVien/San_pham/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            San_pham san_pham = db.San_pham.Find(id);
            if (san_pham == null)
            {
                return HttpNotFound();
            }
            return View(san_pham);
        }

        // GET: NhanVien/San_pham/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NhanVien/San_pham/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id_san_pham,Ten_san_pham,Hinh_anh,Loai_san_pham,Gia_goc,Gia_sale,So_luong,Nguoi_cap_nhat,Ngay_Cap_nhat,Mo_ta_ngan,Mo_ta_dai,Chu_thich,Trang_thai")] San_pham san_pham)
        {
            if (ModelState.IsValid)
            {
                db.San_pham.Add(san_pham);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(san_pham);
        }

        // GET: NhanVien/San_pham/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            San_pham san_pham = db.San_pham.Find(id);
            if (san_pham == null)
            {
                return HttpNotFound();
            }
            return View(san_pham);
        }

        // POST: NhanVien/San_pham/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id_san_pham,Ten_san_pham,Hinh_anh,Loai_san_pham,Gia_goc,Gia_sale,So_luong,Nguoi_cap_nhat,Ngay_Cap_nhat,Mo_ta_ngan,Mo_ta_dai,Chu_thich,Trang_thai")] San_pham san_pham)
        {
            if (ModelState.IsValid)
            {
                db.Entry(san_pham).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(san_pham);
        }

        // GET: NhanVien/San_pham/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            San_pham san_pham = db.San_pham.Find(id);
            if (san_pham == null)
            {
                return HttpNotFound();
            }
            return View(san_pham);
        }

        // POST: NhanVien/San_pham/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            San_pham san_pham = db.San_pham.Find(id);
            db.San_pham.Remove(san_pham);
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
