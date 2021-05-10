﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class TonKhoesController : Controller
    {
        private NNTDbContext db = new NNTDbContext();

        // GET: TonKhos
        [Authorize]
        public ActionResult Index()
        {
            return View(db.TonKhos.ToList());
        }

        // GET: TonKhoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TonKho tonKho = db.TonKhos.Find(id);
            if (tonKho == null)
            {
                return HttpNotFound();
            }
            return View(tonKho);
        }

        // GET: TonKhoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TonKhoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "STT,MaHangHoa,SoNhap,SoXuat,SoTon")] TonKho tonKho)
        {
            if (ModelState.IsValid)
            {
                db.TonKhos.Add(tonKho);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tonKho);
        }

        // GET: TonKhoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TonKho tonKho = db.TonKhos.Find(id);
            if (tonKho == null)
            {
                return HttpNotFound();
            }
            return View(tonKho);
        }

        // POST: TonKhoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "STT,MaHangHoa,SoNhap,SoXuat,SoTon")] TonKho tonKho)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tonKho).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tonKho);
        }

        // GET: TonKhoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TonKho tonKho = db.TonKhos.Find(id);
            if (tonKho == null)
            {
                return HttpNotFound();
            }
            return View(tonKho);
        }

        // POST: TonKhoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TonKho tonKho = db.TonKhos.Find(id);
            db.TonKhos.Remove(tonKho);
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
