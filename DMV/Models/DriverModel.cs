﻿using System;
using System.Collections.Generic;
<<<<<<< Updated upstream
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DMV.Models
{
    public class DriverModel
    {
        [Required]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        public string LastName { get; set; }
=======
using System.Linq;
using System.Web;

namespace DMV.Models.Entity
{
    public class DriverModel
    {
      
>>>>>>> Stashed changes
    }
}