using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ErrorReporting.Models;
using ErrorReporting.ViewModels;
using System.Data.Entity;
using ErrorReporting.Extensions;

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
            var report = _context.BugReport.
                Include(c => c.Browser).
                Include(c => c.OperatingSystem).
                Include(c => c.Status).
                SingleOrDefault(c => c.Id == id);
            
            if (report == null)
                return HttpNotFound();

            return View(report);

        }

        public ActionResult InProgress(int id)
        {
            var report = _context.BugReport.SingleOrDefault(c => c.Id == id);
            report.StatusId = 2;

            _context.SaveChanges();

            this.AddNotification("Status set to 'In Progress.'", NotificationType.INFO);

            return RedirectToAction("Details", "BugReports", new { id = report.Id });
        }
        public ActionResult Resolved(int id)
        {
            var report = _context.BugReport.SingleOrDefault(c => c.Id == id);
            report.StatusId = 3;

            _context.SaveChanges();

            this.AddNotification("Status set to 'Resolved.'", NotificationType.INFO);
            //TODO find way to combine with "InProgress" action to avoid dupe code

            return RedirectToAction("Details", "BugReports", new { id = report.Id });
        }


    }
}
