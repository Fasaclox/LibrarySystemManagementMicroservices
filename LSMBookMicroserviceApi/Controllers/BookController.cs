using LSMBookMicroserviceApi.Context;
using LSMBookMicroserviceApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LSMBookMicroserviceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        // GET: BookController
        private BookContext _bookContext;

        public BookController(BookContext bookContext)
        {
            _bookContext = bookContext;
        }

        // GET: api/<BookController>
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _bookContext.Books;
        }

        // GET api/<BookController>/5
        [HttpGet("{id}")]
        public Book Get(int id)
        {
            return _bookContext.Books.FirstOrDefault(s => s.BookISBN_Id == id);
        }

        // POST api/<BookController>
        [HttpPost]
        public void Post([FromBody] Book value)
        {
            _bookContext.Books.Add(value);
            _bookContext.SaveChanges();
        }

        // PUT api/<BookController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Book value)
        {
            var book = _bookContext.Books.FirstOrDefault(s => s.BookISBN_Id == id);
            if (book != null)
            {
                _bookContext.Entry<Book>(book).CurrentValues.SetValues(value);
                _bookContext.SaveChanges();
            }
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var book = _bookContext.Books.FirstOrDefault(s => s.BookISBN_Id == id);
            if (book != null)
            {
                _bookContext.Books.Remove(book);
                _bookContext.SaveChanges();
            }
        }
    }
}
