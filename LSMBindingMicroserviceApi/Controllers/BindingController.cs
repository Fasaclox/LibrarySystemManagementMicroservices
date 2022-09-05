using LSMBindingMicroserviceApi.Context;
using LSMBindingMicroserviceApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LSMBindingMicroserviceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BindingController : ControllerBase
    {
        // GET: BindingController
        private BindingContext _bindingContext;

        public BindingController(BindingContext bindingContext)
        {
            _bindingContext = bindingContext;
        }

        // GET: api/<BindingController>
        [HttpGet]
        public IEnumerable<Binding> Get()
        {
            return _bindingContext.Bindings;
        }


        // GET api/<BindingController>/5
        [HttpGet("{id}")]
        public Binding Get(int id)
        {
            return _bindingContext.Bindings.FirstOrDefault(s => s.Binding_Id == id);
        }

        // POST api/<BindingController>
        [HttpPost]
        public void Post([FromBody] Binding value)
        {
            _bindingContext.Bindings.Add(value);
            _bindingContext.SaveChanges();
        }

        // PUT api/<BindingController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Binding value)
        {
            var binding = _bindingContext.Bindings.FirstOrDefault(s => s.Binding_Id == id);
            if (binding != null)
            {
                _bindingContext.Entry<Binding>(binding).CurrentValues.SetValues(value);
                _bindingContext.SaveChanges();
            }
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var binding = _bindingContext.Bindings.FirstOrDefault(s => s.Binding_Id == id);
            if (binding != null)
            {
                _bindingContext.Bindings.Remove(binding);
                _bindingContext.SaveChanges();
            }
        }
    }
}
