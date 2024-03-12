
<<<<<<< HEAD

//using Domain.Entities.User;

//namespace Infrastructure.Persistants.Configurations.User
//{
//    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
//    {
//        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
//        {
//            builder.Property(x => x.FullName)
//                .HasMaxLength(50);
//        }
//    }
//}
=======
using Domain.Entities.User;

namespace Infrastructure.Persistants.Configurations.User
{
    internal class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.Property(x => x.Fullname)
                .HasMaxLength(50);

            builder.HasIndex(x=>x.PhoneNumber)
                .IsUnique();
        }
    }
}
>>>>>>> 36b60cbf4346dd2b4774f3093b946930a106efd1
