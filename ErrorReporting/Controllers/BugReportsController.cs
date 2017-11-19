using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ErrorReporting.Models;

namespace ErrorReporting.Controllers
{
    public class BugReportsController : Controller
    {
        private ApplicationDbContext _context;
        public BugReportsController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: BugReports
        public ActionResult Index()
        {
            var reports = _context.BugReport.ToList();
            return View(reports);
        }

        // GET: BugReports/Details/5
        public ActionResult Details(int id)
        {
            var report = _context.BugReport.SingleOrDefault(c => c.Id == id);

            var specificReportBrowser = _context.Browsers.SingleOrDefault(c => c.Id == id);
            report.Browser = specificReportBrowser;

            var specificReportOS = _context.OperatingSystems.SingleOrDefault(c => c.Id == id);
            report.OperatingSystem = specificReportOS;


            if (report == null)
                return HttpNotFound();

            return View(report);

        }

        // GET: BugReports/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BugReports/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BugReports/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BugReports/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BugReports/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BugReports/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
