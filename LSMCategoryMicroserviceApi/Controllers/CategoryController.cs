using LSMCategoryMicroserviceApi.Context;
using LSMCategoryMicroserviceApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LSMCategoryMicroserviceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        // GET: CategoryController
        private CategoryContext _categoryContext;

        public CategoryController(CategoryContext categoryContext)
        {
            _categoryContext = categoryContext;
        }

        // GET: api/<CategoryController>
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return _categoryContext.Categories;
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public Category Get(int id)
        {
            return _categoryContext.Categories.FirstOrDefault(s => s.Category_Id == id);
        }

        // POST api/<CategoryController>
        [HttpPost]
        public void Post([FromBody] Category value)
        {
            _categoryContext.Categories.Add(value);
            _categoryContext.SaveChanges();
        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Category value)
        {
            var category = _categoryContext.Categories.FirstOrDefault(s => s.Category_Id == id);
            if (category != null)
            {
                _categoryContext.Entry<Category>(category).CurrentValues.SetValues(value);
                _categoryContext.SaveChanges();
            }
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var category = _categoryContext.Categories.FirstOrDefault(s => s.Category_Id == id);
            if (category != null)
            {
                _categoryContext.Categories.Remove(category);
                _categoryContext.SaveChanges();
            }
        }
    }
}
