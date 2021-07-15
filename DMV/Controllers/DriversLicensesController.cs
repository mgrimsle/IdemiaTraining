using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DMV.Controllers
{
    public class DriversLicensesController : ApiController
    {
        // GET: api/DriversLicenses
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/DriversLicenses/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/DriversLicenses
        public void Post([FromBody]string value)
        {
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
