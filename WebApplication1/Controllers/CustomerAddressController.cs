using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CustomerAddressController : Controller
    {
        private AdventureWorksLT2012Entities db = new AdventureWorksLT2012Entities();

        // GET: /CustomerAddress/
        public ActionResult Index()
        {
            var customeraddress = db.CustomerAddress.Include(c => c.Address).Include(c => c.Customer);
            return View(customeraddress.ToList());
        }

        // GET: /CustomerAddress/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerAddress customeraddress = db.CustomerAddress.Find(id);
            if (customeraddress == null)
            {
                return HttpNotFound();
            }
            return View(customeraddress);
        }

        // GET: /CustomerAddress/Create
        public ActionResult Create()
        {
            ViewBag.AddressID = new SelectList(db.Address, "AddressID", "AddressLine1");
            ViewBag.CustomerID = new SelectList(db.Customer, "CustomerID", "Title");
            return View();
        }

        // POST: /CustomerAddress/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="CustomerID,AddressID,AddressType,rowguid,ModifiedDate")] CustomerAddress customeraddress)
        {
            if (ModelState.IsValid)
            {
                db.CustomerAddress.Add(customeraddress);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AddressID = new SelectList(db.Address, "AddressID", "AddressLine1", customeraddress.AddressID);
            ViewBag.CustomerID = new SelectList(db.Customer, "CustomerID", "Title", customeraddress.CustomerID);
            return View(customeraddress);
        }

        // GET: /CustomerAddress/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerAddress customeraddress = db.CustomerAddress.Find(id);
            if (customeraddress == null)
            {
                return HttpNotFound();
            }
            ViewBag.AddressID = new SelectList(db.Address, "AddressID", "AddressLine1", customeraddress.AddressID);
            ViewBag.CustomerID = new SelectList(db.Customer, "CustomerID", "Title", customeraddress.CustomerID);
            return View(customeraddress);
        }

        // POST: /CustomerAddress/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="CustomerID,AddressID,AddressType,rowguid,ModifiedDate")] CustomerAddress customeraddress)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customeraddress).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AddressID = new SelectList(db.Address, "AddressID", "AddressLine1", customeraddress.AddressID);
            ViewBag.CustomerID = new SelectList(db.Customer, "CustomerID", "Title", customeraddress.CustomerID);
            return View(customeraddress);
        }

        // GET: /CustomerAddress/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerAddress customeraddress = db.CustomerAddress.Find(id);
            if (customeraddress == null)
            {
                return HttpNotFound();
            }
            return View(customeraddress);
        }

        // POST: /CustomerAddress/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CustomerAddress customeraddress = db.CustomerAddress.Find(id);
            db.CustomerAddress.Remove(customeraddress);
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
