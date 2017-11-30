using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using ErrorReporting.Models;
using ErrorReporting.ViewModels;


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
                var viewModel = new ReportFormViewModel
                {
                    BugReport = bugReport,
                    Browsers = _context.Browsers.ToList(),
                    OperatingSystems = _context.OperatingSystems.ToList()

                };
                return View("BugSubmission", viewModel);
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
            var browsers = _context.Browsers.ToList();
            var operatingSystems = _context.OperatingSystems.ToList();

            var viewModel = new ReportFormViewModel
            {
                Browsers = browsers,
                OperatingSystems = operatingSystems

            };

            return View(viewModel);
            
        }

    }
}