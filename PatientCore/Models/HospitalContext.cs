using Microsoft.EntityFrameworkCore;

namespace HospitalApp.Models
{
    public class HospitalContext:DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options): base(options) 
        {

        }
        public DbSet<Patient>Patients { get; set; }
    }
}
