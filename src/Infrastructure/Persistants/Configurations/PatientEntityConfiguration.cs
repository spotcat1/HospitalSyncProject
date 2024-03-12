

namespace Infrastructure.Persistants.Configurations
{
    internal class PatientEntityConfiguration : IEntityTypeConfiguration<PatientEntity>
    {
        public void Configure(EntityTypeBuilder<PatientEntity> builder)
        {
            builder.ToTable("patients");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.FromDate)
                .IsRequired();

            builder.Property(x => x.ToDate)
                .IsRequired();

            builder
                .HasOne(x => x.User)
                .WithMany(x => x.Patients)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Cascade);



            builder
                .HasMany(x => x.Medications)
                .WithMany(x => x.Patients)
                .UsingEntity(x =>
                {
                    x.ToTable("PatientMedication");
                });
        }
    }
}
