using AutoMapper;
using DMV.Models;
using System;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace DMV.Controllers
{
    [RoutePrefix("api/drivers")]
    public class DriversController : ApiController
    {     
        private readonly IMapper _mapper;

        public DriversController(IMapper mapper)
        {
            _mapper = mapper;

        }
        // GET: api/Drivers
        [Route()]
        [HttpGet]
        public IHttpActionResult GetAllDrivers()
        {
            try
            {
                using (var db = new DMVContext())
                {
                    var results = db.Driver.ToList();

                    if (results.Count() == 0) return NotFound();


                    return Ok(results);
                }
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }
        }

        // GET: api/Drivers/5
        [Route("{id}", Name="GetDriver")]
        [HttpGet]
        public IHttpActionResult GetDriver(int id)
        {
            try
            {
                using (var db = new DMVContext())
                {
                    var driver = db.Driver.Find(id);

                    if (driver == null) return NotFound();

                    return Ok(_mapper.Map<DriverModel>(driver));
                }
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }
        }

        // POST: api/Drivers
        [Route()]
        [HttpPost]
        public async Task<IHttpActionResult> addDriver([FromBody]DriverModel model)
        {
            try
            {
                using (var db = new DMVContext())
                {
                    var driver = _mapper.Map<Driver>(model);

                    if(ModelState.IsValid)
                    {
                        db.Driver.Add(driver);

                        if ( await db.SaveChangesAsync() > 0 )
                        {
                            var newModel = _mapper.Map<DriverModel>(driver);
                            return CreatedAtRoute("GetDriver", new { id = driver.Driver_ID }, newModel);
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

        // PUT: api/Drivers/5
        public void Put(int id, [FromBody]string value)
        {
        }

        //DELETE: api/Drivers/5
        //public void Delete(int id)
        //{
        //}
    }
}
