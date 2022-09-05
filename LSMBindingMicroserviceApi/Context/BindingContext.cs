using LSMBindingMicroserviceApi.Model;
using Microsoft.EntityFrameworkCore;

namespace LSMBindingMicroserviceApi.Context
{
    public class BindingContext : DbContext
    {
        public BindingContext(DbContextOptions options)
            : base(options) 
        {
        }
        public DbSet<Binding> Bindings { get; set; }
    }
}
