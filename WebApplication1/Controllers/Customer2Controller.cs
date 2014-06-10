using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using PagedList;

namespace WebApplication1.Controllers
{
    public class Customer2Controller : Controller
    {
        private AdventureWorksLT2012Entities db = new AdventureWorksLT2012Entities();

        // GET: /Customer2/
        public ActionResult Index(string currentFilter, string searchString, 
            string searchFname,string currentFName,
            string searchMName, string currentMName,
            string searchTitle, string currentTitle,
            int? page)
        {
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
                searchFname = currentFName;
                searchMName = currentMName;
                searchTitle = currentTitle;
            }

            ViewBag.CurrentFilter = searchString;
            ViewBag.CurrentFName = searchFname;
            ViewBag.CurrentMName = searchMName;
            ViewBag.CurrentTitle = searchTitle;

            var customers = db.Customer.Where(c => c.IsDeleted == false);

            if (!string.IsNullOrEmpty(searchString))
            {
                customers = customers.Where(c => c.LastName.ToUpper().Contains(searchString.ToUpper()));
            }

            if (!string.IsNullOrEmpty(searchFname))
            {
                customers = customers.Where(c => c.FirstName.ToUpper().Contains(searchFname.ToUpper()));
            }

            if (!string.IsNullOrEmpty(searchMName))
            {
                customers = customers.Where(c => c.MiddleName.ToUpper().Contains(searchMName.ToUpper()));
            }

            if (!string.IsNullOrEmpty(searchTitle))
            {
                customers = customers.Where(c => c.Title.ToUpper().Contains(searchTitle.ToUpper()));
            }

            int pageSize = 3;
            int pageNumber = page ?? 1;

            return View(customers.OrderBy(c => c.CustomerID).ToPagedList(pageNumber, pageSize));
        }

        // GET: /Customer2/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customer.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // GET: /Customer2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Customer2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CustomerID,NameStyle,Title,FirstName,MiddleName,LastName,Suffix,CompanyName,SalesPerson,EmailAddress,Phone,PasswordHash,PasswordSalt,rowguid,ModifiedDate,IsDeleted")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Customer.Add(customer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customer);
        }

        // GET: /Customer2/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customer.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: /Customer2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CustomerID,NameStyle,Title,FirstName,MiddleName,LastName,Suffix,CompanyName,SalesPerson,EmailAddress,Phone,PasswordHash,PasswordSalt,rowguid,ModifiedDate,IsDeleted")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        // GET: /Customer2/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customer.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: /Customer2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Customer customer = db.Customer.Find(id);
            db.Customer.Remove(customer);
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
