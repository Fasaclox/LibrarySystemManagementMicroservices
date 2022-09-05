using LSMCustomerMicroserviceApi.Context;
using LSMCustomerMicroserviceApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LSMCustomerMicroserviceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        // GET: CustomerController
        private CustomerContext _customerContext;

        public CustomerController(CustomerContext customerContext)
        {
            _customerContext = customerContext;
        }

        // GET: api/<CustomerController>
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _customerContext.Customers;
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            return _customerContext.Customers.FirstOrDefault(s => s.Customer_Id == id);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public void Post([FromBody] Customer value)
        {
            _customerContext.Customers.Add(value);
            _customerContext.SaveChanges();
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Customer value)
        {
            var customer = _customerContext.Customers.FirstOrDefault(s => s.Customer_Id == id);
            if (customer != null)
            {
                _customerContext.Entry<Customer>(customer).CurrentValues.SetValues(value);
                _customerContext.SaveChanges();
            }
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var customer = _customerContext.Customers.FirstOrDefault(s => s.Customer_Id == id);
            if (customer != null)
            {
                _customerContext.Customers.Remove(customer);
                _customerContext.SaveChanges();
            }
        }
    }
}
