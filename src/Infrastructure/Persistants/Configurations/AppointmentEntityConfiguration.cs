

namespace Infrastructure.Persistants.Configurations
{
    internal class AppointmentEntityConfiguration : IEntityTypeConfiguration<AppointmentEntity>
    {
        public void Configure(EntityTypeBuilder<AppointmentEntity> builder)
        {
            builder.ToTable("Appointments");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Description)
                .HasMaxLength(500)
                .IsRequired(false);

            builder
                .Property(x => x.AppointmentDate)
                .IsRequired();


            builder
                .HasOne(x => x.Patient)
                .WithMany(x => x.Appointments)
                .HasForeignKey(x => x.PatientId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(x => x.Doctor)
                .WithMany(x => x.Appointments)
                .HasForeignKey(x => x.DoctorId)
                .OnDelete(DeleteBehavior.NoAction);


            builder
                .HasOne(x => x.Nurse)
                .WithMany(x => x.Appointments)
                .HasForeignKey(x => x.NurseId)
                .OnDelete(DeleteBehavior.NoAction);


            builder
                .HasMany(x => x.Tests)
                .WithMany(x => x.Appointments)
                .UsingEntity(x =>
                {
                    x.ToTable("AppointmentTest");
                });
        }
    }
}
