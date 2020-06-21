using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Modele
{
    public class HospitalContext : DbContext
    {

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Perscription> Perscriptions { get; set; }

        public HospitalContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Doctor>().HasData(
                new Doctor
                {
                    Id = 1,
                    FirstName = "ktos tam",
                    LastName = "asd"
                        
                });
        }

       

        }
}