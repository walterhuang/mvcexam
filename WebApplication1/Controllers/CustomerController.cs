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
    public class CustomerController : Controller
    {
        private AdventureWorksLT2012Entities db = new AdventureWorksLT2012Entities();

        // GET: /Customer/
        public ActionResult Index(
            string searchLastName, string searchFirstName,
            string searchMiddleName, string searchTitle,
            string filterLastName, string filterFirstName,
            string filterMiddleName, string filterTitle,
            int page = 1)
        {
            var customers = db.Customer.Where(c => c.IsDeleted == false);

            var searchCriteria = new[] { searchFirstName, searchLastName, searchMiddleName, searchTitle };
            //if (searchCriteria.Any(s => !string.IsNullOrEmpty(s))) //### kill my day!
            if (searchCriteria.Any(s => s != null))
            {
                page = 1;
            }
            else
            {
                searchLastName = filterLastName;
                searchFirstName = filterFirstName;
                searchMiddleName = filterMiddleName;
                searchTitle = filterTitle;
            }

            if (!string.IsNullOrEmpty(searchLastName))
                customers = customers.Where(c => c.LastName.ToUpper().Contains(searchLastName.ToUpper()));

            if (!string.IsNullOrEmpty(searchFirstName))
                customers = customers.Where(c => c.FirstName.ToUpper().Contains(searchFirstName.ToUpper()));

            if (!string.IsNullOrEmpty(searchMiddleName))
                customers = customers.Where(c => c.MiddleName.ToUpper().Contains(searchMiddleName.ToUpper()));

            if (!string.IsNullOrEmpty(searchTitle))
                customers = customers.Where(c => c.Title.ToUpper().Contains(searchTitle.ToUpper()));

            var data = customers.OrderBy(c => c.CustomerID).ToPagedList(page, 3);
            ViewBag.FilterLastName = searchLastName;
            ViewBag.FilterFirstName = searchFirstName;
            ViewBag.FilterMiddleName = searchMiddleName;
            ViewBag.FilterTitle = searchTitle;

            var titles = db.Customer.Select(c => c.Title).Distinct().ToList();
            ViewBag.TitleList = new SelectList(titles, "Title", "Title");

            return View(data); //db.Customer.ToList());
        }

        // GET: /Customer/Details/5
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
            ViewBag.Addresses = customer.CustomerAddress.Select(a => a.Address).ToList();
            return View(customer);
        }

        // GET: /Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Customer/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CustomerID,NameStyle,Title,FirstName,MiddleName,LastName,Suffix,CompanyName,SalesPerson,EmailAddress,Phone,PasswordHash,PasswordSalt,rowguid,ModifiedDate")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Customer.Add(customer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customer);
        }

        // GET: /Customer/Edit/5
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

        // POST: /Customer/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CustomerID,NameStyle,Title,FirstName,MiddleName,LastName,Suffix,CompanyName,SalesPerson,EmailAddress,Phone,PasswordHash,PasswordSalt,rowguid,ModifiedDate")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        // GET: /Customer/Delete/5
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

        // POST: /Customer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Customer customer = db.Customer.Find(id);
            //db.Customer.Remove(customer);
            customer.IsDeleted = true;
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
