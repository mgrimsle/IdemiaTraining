using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DMV.Models.Entity
{
    public class DriversLicenseModel
    {
        
        [Required]
        public string Status { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        
        public Driver Driver { get; set; }


    }
}