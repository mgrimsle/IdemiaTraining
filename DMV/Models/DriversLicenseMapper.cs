using AutoMapper;
using DMV.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMV.Models
{
    public class DriversLicenseMapper : Profile
    {
        public DriversLicenseMapper()
        {
            CreateMap<DriversLicenseModel, DriversLicense>().ReverseMap();

        }

    }
}
