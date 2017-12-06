using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ErrorReporting.Models
{
    public class Status
    {
        [Range(1, 3)]
        public byte Id { get; set; }
        public string StatusName { get; set; }
    }
}