using Domain;
using Domain.Entities.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Infrastructure.Persistants
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public DbSet<GenderEntity> Genders { get; set; }
        public DbSet<UserEntity> User { get; set; }
        public DbSet<PatientEntity> Patients { get; set; }
        public DbSet<DoctorEntity> Doctors { get; set; }
        public DbSet<NurseEntity> Nurses { get; set; }
        public DbSet<AppointmentEntity> Appointments { get; set; }
        public DbSet<MedicationEntity> Medications { get; set; }
        public DbSet<TestEntity> Tests { get; set; }



        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(DomainSchema.Schema);
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }



    }
}
