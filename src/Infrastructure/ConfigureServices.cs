
using Application.Behaviours;
using Application.Behaviours.User;
using Application.Contracts;
using Application.Dtos.Identity;
using Domain.Entities.User;
using FluentValidation;
using Infrastructure.CrossCutting;
using Infrastructure.Identity;
using Infrastructure.Persistants;
using Infrastructure.Repositories;
using Infrastructure.Services;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Reflection;
using System.Text;

namespace Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("HospitalSyncProjectConnectionString")));


            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            ValidatorOptions.Global.LanguageManager = new ValidatorFluentCustomLanguage();


            services.AddMediatR(options =>
            {
                options.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            }).AddScoped(typeof(IPipelineBehavior<,>), typeof(UserValidationBehaviour<,>))
            .AddScoped(typeof(IPipelineBehavior<,>), typeof(LoggingBehaviour<,>));

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddHttpContextAccessor();

            services.AddScoped<IUserRepository, UserRepositoryImplementation>(); // remove it after ...
            services.AddTransient<IUnitOfWork, UnitOfWorkImplementation>();
            //services.AddTransient((typeof(IGenericRepository<>)), (typeof(GenericRepositoryImplementaton<>)));


            services.AddMemoryCache();
            services.AddScoped<ICacheManagerService, CacheManagerSerivce>();

            services.AddIdentity<ApplicationUser, IdentityRole<Guid>>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 5;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.User.RequireUniqueEmail = true;
                options.SignIn.RequireConfirmedPhoneNumber = false;
                options.SignIn.RequireConfirmedEmail = false;
            }).AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders();



            services.AddTransient<JwtTokenService>();
            services.Configure<JwtOption>(options => configuration.GetSection("JwtOption").Bind(options));
            services.AddAuthentication()
                .AddJwtBearer(options =>
                {
                    options.RequireHttpsMetadata = false;
                    options.SaveToken = true;
                    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ClockSkew = TimeSpan.Zero,
                        ValidIssuer = configuration["JwtOption:Issuer"],
                        ValidAudience = configuration["JwtOption:Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtOption:Key"]))
                    };
                });



            return services;
        }
    }
}
