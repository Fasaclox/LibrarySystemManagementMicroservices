
using LSMStaffMicroserviceApi.Model;
using Microsoft.EntityFrameworkCore;

namespace LSMStaffMicroserviceApi.Context
{
    public class StaffContext : DbContext
    {
        public StaffContext(DbContextOptions<StaffContext> options)
            : base(options) 
        { 
        
        }
        public DbSet<Staff> Staffs { get; set; }
    }
}
