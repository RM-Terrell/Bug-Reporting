using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ErrorReporting.Models;

namespace ErrorReporting.ViewModels
{
    public class ReportFormViewModel
    {
        public IEnumerable<Browsers> Browsers { get; set; }
        public IEnumerable<OperatingSystems> OperatingSystems { get; set; }
        public BugReport BugReport { get; set; }
    }
}