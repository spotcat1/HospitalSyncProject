

<<<<<<< HEAD
//using Domain.Entities.User;
//using Infrastructure.Identity;
//using Microsoft.AspNetCore.Identity;

//namespace Infrastructure.Persistants
//{
//    public static class DbInitializer
//    {
//        public static void Seed(this ApplicationDbContext context)
//        {
//            context.Database.EnsureCreated();

//            if (context.Roles.Any())
//            {
//                return;
//            }


//            using var Transaction = context.Database.BeginTransaction();

//            var AdminRole = new IdentityRole<Guid>
//            {
//                Name = UserRoleNames.Admin,
//                NormalizedName = UserRoleNames.Admin.ToUpper(),
//                ConcurrencyStamp = Guid.NewGuid().ToString(),
//            };

//            var ManagerRole = new IdentityRole<Guid>
//            {
//                Name = UserRoleNames.Manager,
//                NormalizedName = UserRoleNames.Manager.ToUpper(),
//                ConcurrencyStamp = Guid.NewGuid().ToString(),
//            };

//            context.Roles.AddRange(AdminRole,ManagerRole);
//            context.SaveChanges();


//            ApplicationUser AdminUser = new ApplicationUser
//            {
//                ConcurrencyStamp = Guid.NewGuid().ToString(),
//                SecurityStamp = Guid.NewGuid().ToString(),
//                UserName = "Admin",
//                NormalizedUserName = "admin".ToUpper(),
//                FullName = "Admin_User",
//            };




//            ApplicationUser ManagerUser = new ApplicationUser
//            {
//                ConcurrencyStamp = Guid.NewGuid().ToString(),
//                SecurityStamp = Guid.NewGuid().ToString(),
//                UserName = "Manager",
//                NormalizedUserName = "manager".ToUpper(),
//                FullName = "Manager_User",
//            };

//            PasswordHasher<ApplicationUser> PassWordHasher = new();

//            AdminUser.PasswordHash = PassWordHasher.HashPassword(AdminUser, "ljboa_ygouou9367642iu");
//            ManagerUser.PasswordHash = PassWordHasher.HashPassword(ManagerUser, "24355342_duhbA");

//            context.Users.AddRange(AdminUser, ManagerUser);
//        }
//    }
//}
=======
using Domain.Entities.User;
using Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Persistants
{
    public static class DbInitializer
    {
        public static void Seed(this ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Roles.Any())
            {
                return;
            }


            using var Transaction = context.Database.BeginTransaction();

            var AdminRole = new IdentityRole<Guid>
            {
                Name = UserRoleNames.Admin,
                NormalizedName = UserRoleNames.Admin.ToUpper(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
            };

            var ManagerRole = new IdentityRole<Guid>
            {
                Name = UserRoleNames.Manager,
                NormalizedName = UserRoleNames.Manager.ToUpper(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
            };

            context.Roles.AddRange(AdminRole, ManagerRole);
            context.SaveChanges();


            ApplicationUser AdminUser = new()
            {
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = "admin",
                NormalizedUserName = "admin".ToUpper(),
                Fullname = "Admin_User"
            };


            ApplicationUser ManagerUser = new()
            {
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = "manager",
                NormalizedUserName = "manager".ToUpper(),
                Fullname = "Manager_User"
            };

            PasswordHasher<ApplicationUser> passwordHasher = new();
            AdminUser.PasswordHash = passwordHasher.HashPassword(AdminUser, "1234678ADS92Asgdu_aw");
            ManagerUser.PasswordHash = passwordHasher.HashPassword(ManagerUser, "34873478ljjhDDbljasdg_seere");
            context.Users.AddRange(AdminUser, ManagerUser);
            context.SaveChanges();

            context.UserRoles.Add(new IdentityUserRole<Guid>
            {
                UserId = AdminUser.Id,
                RoleId = AdminRole.Id
            });


            context.UserRoles.Add(new IdentityUserRole<Guid>
            {
                UserId = ManagerUser.Id,
                RoleId = ManagerRole.Id
            });

            context.SaveChanges();
            Transaction.Commit();

        }
    }
}
>>>>>>> 36b60cbf4346dd2b4774f3093b946930a106efd1
