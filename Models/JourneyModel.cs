using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JourneyPlanner.Models
{
    public class JourneyModel
    {
        [Required]
        public string From { get; set; }
        [Required]
        public string To { get; set; }
        public string ViaFrom { get; set; }
        public string ViaTo { get; set; }
    }
}