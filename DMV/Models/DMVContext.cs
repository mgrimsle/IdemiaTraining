using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DMV.Models
{
    public class DMVContext : DbContext
    {
        public DbSet<DriverDataModel> Driver { get; set; }
    }
}