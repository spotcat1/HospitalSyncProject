﻿// <auto-generated />
using System;
using Infrastructure.Persistants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Persistants.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240210044207_IdentityMigration")]
    partial class IdentityMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("MahanOwji")
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AppointmentEntityTestEntity", b =>
                {
                    b.Property<Guid>("AppointmentsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TestsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AppointmentsId", "TestsId");

                    b.HasIndex("TestsId");

                    b.ToTable("AppointmentTest", "MahanOwji");
                });

            modelBuilder.Entity("Domain.Entities.AppointmentEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<Guid>("DoctorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("NurseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PatientId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("NurseId");

                    b.HasIndex("PatientId");

                    b.ToTable("Appointments", "MahanOwji");
                });

            modelBuilder.Entity("Domain.Entities.DoctorEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ToDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Doctors", "MahanOwji");
                });

            modelBuilder.Entity("Domain.Entities.GenderEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Genders", "MahanOwji");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a0465add-8b12-4d42-b3c5-f91dc6177227"),
                            Title = "مرد"
                        },
                        new
                        {
                            Id = new Guid("9728f42a-9914-4399-937f-c3749efc2703"),
                            Title = "زن"
                        });
                });

            modelBuilder.Entity("Domain.Entities.MedicationEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasMaxLength(800)
                        .HasColumnType("nvarchar(800)");

                    b.Property<string>("Dosage")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Medications", "MahanOwji");
                });

            modelBuilder.Entity("Domain.Entities.NurseEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ToDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Nurses", "MahanOwji");
                });

            modelBuilder.Entity("Domain.Entities.PatientEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ToDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("patients", "MahanOwji");
                });

            modelBuilder.Entity("Domain.Entities.TestEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Tests", "MahanOwji");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c268729e-708f-43eb-8e32-2b338a627c81"),
                            Description = "این آزمایش میزان سلول‌های قرمز خون را در مقدار کل خون اندازه‌گیری می‌کند",
                            Name = "آزمایش هماتوکریت (Hematocrit)"
                        },
                        new
                        {
                            Id = new Guid("80e8d8ee-a2da-4f83-b6a3-2466e0f6fa04"),
                            Description = " این آزمایش سطح گلوکز یا قند خون را اندازه‌گیری می‌کند و برای تشخیص دیابت استفاده می‌شود",
                            Name = "آزمایش گلوکز (Glucose)"
                        },
                        new
                        {
                            Id = new Guid("28d0d9ad-55dd-47b2-9b36-d54f8b0e717a"),
                            Description = "این آزمایش میزان کلسترول در خون را اندازه‌گیری کرده و ممکن است به ارزیابی خطر ابتلا به بیماری‌های قلبی کمک کند",
                            Name = "آزمایش کلسترول (Cholesterol)"
                        },
                        new
                        {
                            Id = new Guid("621dda4e-f377-4539-9095-da659c6424a3"),
                            Description = "این آزمایش میزان هورمون‌های تیروئید را بررسی می‌کند و مشکلات در عملکرد تیروئید را تشخیص می‌دهد",
                            Name = "آزمایش هورمون تیروئید (Thyroid Hormones)"
                        },
                        new
                        {
                            Id = new Guid("71bb63bb-a907-4617-a78a-661bf2f01fae"),
                            Description = "این آزمایش مقدار آهن در خون را اندازه‌گیری می‌کند و مشکلات مرتبط با کم‌خونی یا افزایش آهن را تشخیص می‌دهد",
                            Name = "آزمایش آهن (Iron)"
                        },
                        new
                        {
                            Id = new Guid("76bd529a-3c57-43ec-b754-a2213f68de06"),
                            Description = "این آزمایش مخلوط ادرار را بررسی می‌کند و ممکن است به تشخیص برخی مشکلات کلیه یا دیگر مشکلات سلامتی کمک کند",
                            Name = "آزمایش ادرار (Urinalysis)"
                        },
                        new
                        {
                            Id = new Guid("1a64ef8b-d105-4b97-ba3d-1c63ca6665f6"),
                            Description = "این آزمایش فعالیت آنزیم آمیلاز را اندازه‌گیری می‌کند که به تشخیص برخی مشکلات در لاپاره یا پانکراس کمک می‌کند",
                            Name = "آزمایش آمیلاز (Amylase)"
                        },
                        new
                        {
                            Id = new Guid("040dca85-7c59-4c49-a4db-459b966e5533"),
                            Description = "این آزمایش سطح پروتئین واکنش التهابی را اندازه‌گیری می‌کند و در تشخیص التهاب‌ها و بیماری‌های التهابی مفید است",
                            Name = "آزمایش CRP (پروتئین واکنش التهابی)"
                        },
                        new
                        {
                            Id = new Guid("eea41e88-7a61-4a52-88d5-09d63d399315"),
                            Description = "این آزمایش مقدار اسید اوریک در خون را اندازه‌گیری می‌کند و ممکن است به تشخیص مشکلات مرتبط با نقرس کمک کند",
                            Name = "آزمایش اسید اوریک (Uric Acid)"
                        },
                        new
                        {
                            Id = new Guid("4ceccd31-9828-425a-bb2f-ec5844fe7e10"),
                            Description = "این آزمایش فعالیت آنزیم‌های کبدی را بررسی می‌کند و به تشخیص مشکلات کبدی مانند التهاب یا آسیب به کبد کمک می‌کند",
                            Name = "آزمایش آنزیم‌های کبدی (Liver Enzymes)"
                        },
                        new
                        {
                            Id = new Guid("64411787-2f78-4e40-829b-0d52667ccc94"),
                            Description = " این آزمایش فشار خون را اندازه‌گیری می‌کند و در ارزیابی سلامت قلب و عروق مفید است",
                            Name = "آزمایش فشار خون (Blood Pressure)"
                        },
                        new
                        {
                            Id = new Guid("cabf1cf9-1bde-495b-844e-51bf41c3c7f1"),
                            Description = "این آزمایش یک مجموعه جامع از آزمایش‌های شیمیایی را انجام می‌دهد تا وضعیت کلی سلامت افراد را ارزیابی کند",
                            Name = "آزمایش کلیت (Comprehensive Metabolic Panel)"
                        });
                });

            modelBuilder.Entity("Domain.Entities.User.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", "MahanOwji");
                });

            modelBuilder.Entity("Domain.Entities.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Biography")
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasMaxLength(500)
                        .HasColumnType("datetime2");

                    b.Property<string>("FatherName")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<Guid>("GenderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("IdentityCode")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("ImagePath")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Nationality")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("PassWord")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.HasIndex("GenderId");

                    b.HasIndex("IdentityCode")
                        .IsUnique();

                    b.ToTable("Users", "MahanOwji");
                });

            modelBuilder.Entity("MedicationEntityPatientEntity", b =>
                {
                    b.Property<Guid>("MedicationsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PatientsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MedicationsId", "PatientsId");

                    b.HasIndex("PatientsId");

                    b.ToTable("PatientMedication", "MahanOwji");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", "MahanOwji");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", "MahanOwji");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", "MahanOwji");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", "MahanOwji");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", "MahanOwji");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", "MahanOwji");
                });

            modelBuilder.Entity("AppointmentEntityTestEntity", b =>
                {
                    b.HasOne("Domain.Entities.AppointmentEntity", null)
                        .WithMany()
                        .HasForeignKey("AppointmentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.TestEntity", null)
                        .WithMany()
                        .HasForeignKey("TestsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.AppointmentEntity", b =>
                {
                    b.HasOne("Domain.Entities.DoctorEntity", "Doctor")
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Domain.Entities.NurseEntity", "Nurse")
                        .WithMany("Appointments")
                        .HasForeignKey("NurseId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Domain.Entities.PatientEntity", "Patient")
                        .WithMany("Appointments")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Nurse");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Domain.Entities.DoctorEntity", b =>
                {
                    b.HasOne("Domain.Entities.UserEntity", "User")
                        .WithMany("Doctors")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entities.NurseEntity", b =>
                {
                    b.HasOne("Domain.Entities.UserEntity", "User")
                        .WithMany("Nurses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entities.PatientEntity", b =>
                {
                    b.HasOne("Domain.Entities.UserEntity", "User")
                        .WithMany("Patients")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entities.UserEntity", b =>
                {
                    b.HasOne("Domain.Entities.GenderEntity", "Gender")
                        .WithMany("Users")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gender");
                });

            modelBuilder.Entity("MedicationEntityPatientEntity", b =>
                {
                    b.HasOne("Domain.Entities.MedicationEntity", null)
                        .WithMany()
                        .HasForeignKey("MedicationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.PatientEntity", null)
                        .WithMany()
                        .HasForeignKey("PatientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("Domain.Entities.User.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("Domain.Entities.User.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.User.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("Domain.Entities.User.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.DoctorEntity", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("Domain.Entities.GenderEntity", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Domain.Entities.NurseEntity", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("Domain.Entities.PatientEntity", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("Domain.Entities.UserEntity", b =>
                {
                    b.Navigation("Doctors");

                    b.Navigation("Nurses");

                    b.Navigation("Patients");
                });
#pragma warning restore 612, 618
        }
    }
}