﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using V1_BTL_CNPM.Controllers.admin;
using V1_BTL_CNPM.Models;

namespace V1_BTL_CNPM.Controllers
{
    public class nganhsController : BaseController
    {
        private db_cnpm_v3_1Entities db = new db_cnpm_v3_1Entities();

        // GET: nganhs
        public ActionResult Index()
        {
            var nganhs = db.nganhs.Include(n => n.khoa);
            return View(nganhs.ToList());
        }

       

        // GET: nganhs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nganh nganh = db.nganhs.Find(id);
            if (nganh == null)
            {
                return HttpNotFound();
            }
            return View(nganh);
        }

        // GET: nganhs/Create
        public ActionResult Create()
        {
            ViewBag.MaKhoa = new SelectList(db.khoas, "MaKhoa", "TenKhoa");
            return View();
        }

        public bool CheckMaNganh(string manganh)
        {
            return db.nganhs.Count(x => x.MaNganh == manganh) > 0;
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(nganh nganh)
        {
            if (ModelState.IsValid)
            {
                if (CheckMaNganh(nganh.MaNganh))
                {
                    Response.Write("<script>alert('Ngành học này đã tồn tại')</script>");
                }
                else
                {
                    db.nganhs.Add(nganh);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                
            }

            ViewBag.MaKhoa = new SelectList(db.khoas, "MaKhoa", "TenKhoa", nganh.MaKhoa);
            return View(nganh);
        }

        // GET: nganhs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nganh nganh = db.nganhs.Find(id);
            if (nganh == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaKhoa = new SelectList(db.khoas, "MaKhoa", "TenKhoa", nganh.MaKhoa);
            return View(nganh);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaNganh,TenNganh,MaKhoa")] nganh nganh)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nganh).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaKhoa = new SelectList(db.khoas, "MaKhoa", "TenKhoa", nganh.MaKhoa);
            return View(nganh);
        }

        // GET: nganhs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nganh nganh = db.nganhs.Find(id);
            if (nganh == null)
            {
                return HttpNotFound();
            }
            return View(nganh);
        }

        // POST: nganhs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            nganh nganh = db.nganhs.Find(id);
            db.nganhs.Remove(nganh);
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


        public ActionResult Search(string searchString)
        {
            var links = from l in db.nganhs
                        select l;

            if (!String.IsNullOrEmpty(searchString))
            {
                links = links.Where(s => s.TenNganh.Contains(searchString));
            }

            return View(links);
        }


    }
}
