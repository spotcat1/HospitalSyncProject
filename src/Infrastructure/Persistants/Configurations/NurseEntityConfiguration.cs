

namespace Infrastructure.Persistants.Configurations
{
    internal class NurseEntityConfiguration : IEntityTypeConfiguration<NurseEntity>
    {
        public void Configure(EntityTypeBuilder<NurseEntity> builder)
        {
            builder.ToTable("Nurses");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.FromDate)
                .IsRequired();

            builder.Property(x => x.ToDate)
                .IsRequired();


            builder
                .HasOne(x => x.User)
                .WithMany(x => x.Nurses)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
