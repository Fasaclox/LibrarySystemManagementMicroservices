using LSMCategoryMicroserviceApi.Model;
using Microsoft.EntityFrameworkCore;

namespace LSMCategoryMicroserviceApi.Context
{
    public class CategoryContext : DbContext
    {
        public CategoryContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<Category>Categories { get; set; } 
    }
}
