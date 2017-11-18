using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using ErrorReporting.Models;

namespace ErrorReporting.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;
        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        public ActionResult About()
        {
            return View();
        }
        public ActionResult SubmissionSuccess()
        {
            return View();
        }
      
        public ActionResult Save(BugReport bugReport)
        {
            if (!ModelState.IsValid)
            {
                return View("BugSubmission", GenerateModel());
            }
            else
            {
                _context.BugReport.Add(bugReport);
                _context.SaveChanges();

                return RedirectToAction("SubmissionSuccess", "Home");
            }            
        }
        
        public ActionResult BugSubmission()
        {
            ViewBag.Message = "Submission form.";

            return View(GenerateModel());
        }

        private BugReport GenerateModel()
        {
            var model = new BugReport();
            var listInitialOS = _context.OperatingSystems.ToList(); // Mysteries of C# typing
            var listFinalOS = listInitialOS.Select(os => new OperatingSystems { OperatingSystemName = os.OperatingSystemName, Id = os.Id }).ToList();

            var listInitialBrowser = _context.Browsers.ToList(); // More mysteries
            var listFinalBrowser = listInitialBrowser.Select(br => new Browsers { BrowserName = br.BrowserName, Id = br.Id }).ToList();

            model.BrowserList = listFinalBrowser;
            model.OperatingSystemList = listFinalOS;            

            return model;
        }
    }
}