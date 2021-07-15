using DMV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using DMV.Models.Entity;
using System.Threading.Tasks;

namespace DMV.Controllers
{
    [RoutePrefix("api/driverslicenses")]

    public class DriversLicensesController : ApiController
    {

        private readonly IMapper _mapper;
        public DriversLicensesController(IMapper mapper)
        {
            _mapper = mapper;
        }
        // GET: api/DriversLicenses
        [Route()]
        public IHttpActionResult Get()
        {
            try
            {
                using (var db = new DMVContext())
                {
                    var query = db.DriversLicense;
                    return Ok("Sup");
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }          
        }

        // GET: api/DriversLicenses/5
        [Route("{id}", Name = "getDriversLicense")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/DriversLicenses
        [Route()]
        public async Task<IHttpActionResult> Post([FromBody]DriversLicenseModel Model)
        {
            try
            {
                using (var db = new DMVContext())
                {

                    if (ModelState.IsValid)
                    {
                        var DriversLicense = _mapper.Map<DriversLicense>(Model);
                        db.DriversLicense.Add(DriversLicense);
                        if (await db.SaveChangesAsync() > 0)
                        {
                            return CreatedAtRoute("getDriversLicense", DriversLicense.Id, _mapper.Map<DriversLicenseModel>(DriversLicense));
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }
            return BadRequest(ModelState);
           
        }

        // PUT: api/DriversLicenses/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/DriversLicenses/5
        public void Delete(int id)
        {
        }
    }
}
