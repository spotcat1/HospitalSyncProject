﻿

namespace Infrastructure.Persistants.Configurations
{
    internal class GenderEntityConfiguration : IEntityTypeConfiguration<GenderEntity>
    {
        public void Configure(EntityTypeBuilder<GenderEntity> builder)
        {
            builder.ToTable("Genders");

            builder.HasKey(x => x.Id);


            builder.Property(x => x.Title)
                .HasMaxLength(100)
                .IsRequired();



            builder.HasData(new GenderEntity
            {
                Id = Guid.NewGuid(),
                Title = "مرد",
            }, new GenderEntity
            {
                Id=Guid.NewGuid(),
                Title="زن"
            });
        }
    }
}
