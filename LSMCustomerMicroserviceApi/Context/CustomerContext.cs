using LSMCustomerMicroserviceApi.Model;
using Microsoft.EntityFrameworkCore;

namespace LSMCustomerMicroserviceApi.Context
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions options)
            : base(options) 
        {
        
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
