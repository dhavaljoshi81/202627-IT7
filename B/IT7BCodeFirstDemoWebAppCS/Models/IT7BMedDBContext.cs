using Microsoft.EntityFrameworkCore;

namespace IT7BCodeFirstDemoWebAppCS.Models
{
    public class IT7BMedDBContext : DbContext
    {
        public IT7BMedDBContext(DbContextOptions<IT7BMedDBContext> options) 
            : base(options)
        {
        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
    
    }
}
