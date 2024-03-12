

namespace Infrastructure.Persistants.Configurations
{
    internal class UserEntityConfiguration : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.FirstName)
                .HasMaxLength(500)
                .IsRequired();

            builder.Property(x => x.LastName)
            .HasMaxLength(500)
            .IsRequired();

            builder.Property(x => x.FatherName)
            .HasMaxLength(500)
            .IsRequired();


            builder.Property(x=>x.Biography)
                .HasMaxLength(5000)
                .IsRequired(false);


            builder.Property(x => x.BirthDate)
            .HasMaxLength(500)
            .IsRequired();


            builder.HasIndex(x => x.IdentityCode)
                .IsUnique();

            builder.Property(x => x.IdentityCode)
                .HasMaxLength(11)
                .IsRequired();


            builder.Property(x => x.Address)
            .HasMaxLength(1000)
            .IsRequired(false);


            builder.Property(x => x.ImagePath)
            .HasMaxLength(1000)
            .IsRequired(false);



            builder.Property(x => x.Nationality)
            .HasMaxLength(500)
            .IsRequired(false);


            builder
                .HasOne(x => x.Gender)
                .WithMany(x => x.Users)
                .HasForeignKey(x => x.GenderId)
                .OnDelete(DeleteBehavior.Cascade);
            
        }
    }
}
