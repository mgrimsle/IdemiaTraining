using System;
using System.ComponentModel.DataAnnotations;


namespace DMV.Models
{
    public class DriverDataModel
    {
        [Required]
        [Key]
        public int Driver_ID { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        public string LastName { get; set; }
        public DriversLicenseDataModel License { get; set; }
    }
}