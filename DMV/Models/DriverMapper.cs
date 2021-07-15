using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;

namespace DMV.Models
{
    public class DriverMapper : Profile
    {
        public DriverMapper()
        {
            CreateMap<Driver, DriverModel>().ReverseMap();
        }
        
    }
}