using LSMBookMicroserviceApi.Model;
using Microsoft.EntityFrameworkCore;

namespace LSMBookMicroserviceApi.Context
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions options)
            : base(options)
        {
        
        }
        public DbSet<Book> Books { get; set; }
    }
}
