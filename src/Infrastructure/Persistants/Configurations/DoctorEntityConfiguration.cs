

namespace Infrastructure.Persistants.Configurations
{
    internal class DoctorEntityConfiguration : IEntityTypeConfiguration<DoctorEntity>
    {
        public void Configure(EntityTypeBuilder<DoctorEntity> builder)
        {
            builder.ToTable("Doctors");


            builder.HasKey(x => x.Id);


            builder.Property(x => x.FromDate)
                .IsRequired();

            builder.Property(x => x.ToDate)
                .IsRequired();



            builder
                .HasOne(x => x.User)
                .WithMany(x => x.Doctors)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
