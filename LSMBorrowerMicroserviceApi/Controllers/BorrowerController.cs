using LSMBorrowerMicroserviceApi.Context;
using LSMBorrowerMicroserviceApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LSMBorrowerMicroserviceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BorrowerController : ControllerBase
    {
        // GET: BorrowerController
        private BorrowerContext _borrowerContext;

        public BorrowerController(BorrowerContext borrowerContext)
        {
            _borrowerContext = borrowerContext;
        }

        // GET: api/<BorrowerController>
        [HttpGet]
        public IEnumerable<Borrower> Get()
        {
            return _borrowerContext.Borrowers;
        }

        // GET api/<BorrowerController>/5
        [HttpGet("{id}")]
        public Borrower Get(int id)
        {
            return _borrowerContext.Borrowers.FirstOrDefault(s => s.Borrower_Id == id);
        }

        // POST api/<BorrowerController>
        [HttpPost]
        public void Post([FromBody] Borrower value)
        {
            _borrowerContext.Borrowers.Add(value);
            _borrowerContext.SaveChanges();
        }

        // PUT api/<BorrowerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Borrower value)
        {
            var borrower = _borrowerContext.Borrowers.FirstOrDefault(s => s.Borrower_Id == id);
            if (borrower != null)
            {
                _borrowerContext.Entry<Borrower>(borrower).CurrentValues.SetValues(value);
                _borrowerContext.SaveChanges();
            }
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var borrower = _borrowerContext.Borrowers.FirstOrDefault(s => s.Borrower_Id == id);
            if (borrower != null)
            {
                _borrowerContext.Borrowers.Remove(borrower);
                _borrowerContext.SaveChanges();
            }
        }
    }
}
