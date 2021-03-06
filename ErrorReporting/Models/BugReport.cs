﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace ErrorReporting.Models
{
    public class BugReport
    {
        public int Id { get; set; }

        [Required]
        [Display(Name ="Submitter Name")]
        public string Name { get; set; }

        [Display(Name="Error Message")]
        public string ErrorMessage { get; set; }

        [Range(1,5)]
        [Display(Name = "Severity")]
        [Required]
        public int Severity { get; set; }

        public Browsers Browser { get; set; }

        public List<Browsers> BrowserList { get; set; }

        [Display(Name = "Browser")]
        [Required]
        public byte BrowserId { get; set; }

        [Display(Name = "Description")]
        [Required]
        public string Description { get; set; }

        [Display(Name = "Reproduction")]
        [Required]
        public string Reproduction { get; set; }

        public OperatingSystems OperatingSystem { get; set; }

        public List<OperatingSystems> OperatingSystemList { get; set; }

        [Display(Name = "Operating System")]
        [Required]
        public byte OperatingSystemId { get; set; }

        [Display(Name = "Date of Occurrence")]
        [Required]
        public DateTime BugOccurrenceDate { get; set; }

        [Display(Name = "Date of Submission")]
        [Required]
        public DateTime SubmissionDate { get; set; }

        [Required]
        [Display(Name = "Report Status")]

        public byte StatusId { get; set; }
        public Status Status { get; set; }

    }
}