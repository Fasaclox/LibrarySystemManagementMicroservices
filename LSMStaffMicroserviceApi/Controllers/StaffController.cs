using LSMStaffMicroserviceApi.Context;
using LSMStaffMicroserviceApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSMStaffMicroserviceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly StaffContext _staffContext;
        public StaffController(StaffContext staffContext) => _staffContext = staffContext;


        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<Staff> Get()
        {
            return _staffContext.Staffs;
        }

        // GET 
        [HttpGet("{id}")]
        public Staff Get(int id)
        {
            return _staffContext.Staffs.FirstOrDefault(s => s.Staff_Id == id);
        }
        // POST
        [HttpPost]
        public void Post([FromBody] Staff value)
        {
            _staffContext.Staffs.Add(value);
            _staffContext.SaveChanges();
        }

        // PUT 
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Staff value)
        {
            var staff = _staffContext.Staffs.FirstOrDefault(s => s.Staff_Id == id);
            if (staff != null)
            {
                _staffContext.Entry<Staff>(staff).CurrentValues.SetValues(value);
                _staffContext.SaveChanges();
            }
        }

        // DELETE
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var staff = _staffContext.Staffs.FirstOrDefault(s => s.Staff_Id == id);
            if (staff != null)
            {
                _staffContext.Staffs.Remove(staff);
                _staffContext.SaveChanges();
            }
        }

    }
}
