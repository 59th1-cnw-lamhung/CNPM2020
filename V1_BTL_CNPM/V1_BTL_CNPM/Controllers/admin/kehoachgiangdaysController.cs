﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using V1_BTL_CNPM.Models;

namespace V1_BTL_CNPM.Controllers.admin
{
    public class kehoachgiangdaysController : Controller
    {
        private db_cnpm_v3_1Entities db = new db_cnpm_v3_1Entities();

        // GET: kehoachgiangdays
        public ActionResult Index()
        {
            var kehoachgiangdays = db.kehoachgiangdays.Include(k => k.giangvien).Include(k => k.mon);
            return View(kehoachgiangdays.ToList());
        }

        // GET: kehoachgiangdays/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            kehoachgiangday kehoachgiangday = db.kehoachgiangdays.Find(id);
            if (kehoachgiangday == null)
            {
                return HttpNotFound();
            }
            return View(kehoachgiangday);
        }

        // GET: kehoachgiangdays/Create
        public ActionResult Create()
        {
            ViewBag.MaGV = new SelectList(db.giangviens, "MaGV", "HoTenGV");
            ViewBag.MaMon = new SelectList(db.mons, "MaMon", "TenMon");
            return View();
        }

        // POST: kehoachgiangdays/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaKHGD,MaMon,DiaDiemDK,ThoiGianDKBD,ThoiGianDKKT,MaGV")] kehoachgiangday kehoachgiangday)
        {
            if (ModelState.IsValid)
            {
                db.kehoachgiangdays.Add(kehoachgiangday);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaGV = new SelectList(db.giangviens, "MaGV", "HoTenGV", kehoachgiangday.MaGV);
            ViewBag.MaMon = new SelectList(db.mons, "MaMon", "TenMon", kehoachgiangday.MaMon);
            return View(kehoachgiangday);
        }

        // GET: kehoachgiangdays/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            kehoachgiangday kehoachgiangday = db.kehoachgiangdays.Find(id);
            if (kehoachgiangday == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaGV = new SelectList(db.giangviens, "MaGV", "HoTenGV", kehoachgiangday.MaGV);
            ViewBag.MaMon = new SelectList(db.mons, "MaMon", "TenMon", kehoachgiangday.MaMon);
            return View(kehoachgiangday);
        }

        // POST: kehoachgiangdays/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaKHGD,MaMon,DiaDiemDK,ThoiGianDKBD,ThoiGianDKKT,MaGV")] kehoachgiangday kehoachgiangday)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kehoachgiangday).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaGV = new SelectList(db.giangviens, "MaGV", "HoTenGV", kehoachgiangday.MaGV);
            ViewBag.MaMon = new SelectList(db.mons, "MaMon", "TenMon", kehoachgiangday.MaMon);
            return View(kehoachgiangday);
        }

        // GET: kehoachgiangdays/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            kehoachgiangday kehoachgiangday = db.kehoachgiangdays.Find(id);
            if (kehoachgiangday == null)
            {
                return HttpNotFound();
            }
            return View(kehoachgiangday);
        }

        // POST: kehoachgiangdays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            kehoachgiangday kehoachgiangday = db.kehoachgiangdays.Find(id);
            db.kehoachgiangdays.Remove(kehoachgiangday);
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
