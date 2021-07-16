using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DMV.Models
{
    public class DMVContext : DbContext
    {

        public DMVContext() : base("name=DMVDB")
        {
        }

        public DbSet<Driver> Driver { get; set; }
        public DbSet<DriversLicense> DriversLicense { get; set; }
    }
}