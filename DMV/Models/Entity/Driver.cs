using System;
using System.ComponentModel.DataAnnotations;


namespace DMV.Models
{
    public class Driver
    {
        [Required]
        [Key]
        public int Driver_ID { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        public string LastName { get; set; }
        public DriversLicense License { get; set; }
    }
}