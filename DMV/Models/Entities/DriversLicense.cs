using System;
using System.ComponentModel.DataAnnotations;

namespace DMV.Models
{
    public class DriversLicense
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public Driver Driver { get; set; }
    }
}