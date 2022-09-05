using LSMBorrowerMicroserviceApi.Model;
using Microsoft.EntityFrameworkCore;

namespace LSMBorrowerMicroserviceApi.Context
{
    public class BorrowerContext : DbContext
    {
        public BorrowerContext(DbContextOptions options)
            : base(options)
        { 
        }
        public DbSet<Borrower>Borrowers { get; set; } 
    }
}
