

namespace Infrastructure.Persistants.Configurations
{
    internal class MedicationEntityConfiguration : IEntityTypeConfiguration<MedicationEntity>
    {
        public void Configure(EntityTypeBuilder<MedicationEntity> builder)
        {
            builder.ToTable("Medications");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.Dosage)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.Description)
                .HasMaxLength(800)
                .IsRequired(false);

            builder
                .HasMany(x => x.Patients)
                .WithMany(x => x.Medications)
                .UsingEntity(x =>
                {
                    x.ToTable("PatientMedication");
                });
          
                    


        }
    }
}
