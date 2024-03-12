using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Persistants.Migrations
{
    /// <inheritdoc />
    public partial class innit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "MahanOwji");

            migrationBuilder.CreateTable(
                name: "Genders",
                schema: "MahanOwji",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medications",
                schema: "MahanOwji",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Dosage = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tests",
                schema: "MahanOwji",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "MahanOwji",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    FatherName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Biography = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", maxLength: 500, nullable: false),
                    IdentityCode = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Genders_GenderId",
                        column: x => x.GenderId,
                        principalSchema: "MahanOwji",
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                schema: "MahanOwji",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctors_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "MahanOwji",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Nurses",
                schema: "MahanOwji",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nurses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nurses_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "MahanOwji",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "patients",
                schema: "MahanOwji",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_patients_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "MahanOwji",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                schema: "MahanOwji",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NurseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppointmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalSchema: "MahanOwji",
                        principalTable: "Doctors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Appointments_Nurses_NurseId",
                        column: x => x.NurseId,
                        principalSchema: "MahanOwji",
                        principalTable: "Nurses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Appointments_patients_PatientId",
                        column: x => x.PatientId,
                        principalSchema: "MahanOwji",
                        principalTable: "patients",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PatientMedication",
                schema: "MahanOwji",
                columns: table => new
                {
                    MedicationsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientMedication", x => new { x.MedicationsId, x.PatientsId });
                    table.ForeignKey(
                        name: "FK_PatientMedication_Medications_MedicationsId",
                        column: x => x.MedicationsId,
                        principalSchema: "MahanOwji",
                        principalTable: "Medications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientMedication_patients_PatientsId",
                        column: x => x.PatientsId,
                        principalSchema: "MahanOwji",
                        principalTable: "patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppointmentTest",
                schema: "MahanOwji",
                columns: table => new
                {
                    AppointmentsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TestsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentTest", x => new { x.AppointmentsId, x.TestsId });
                    table.ForeignKey(
                        name: "FK_AppointmentTest_Appointments_AppointmentsId",
                        column: x => x.AppointmentsId,
                        principalSchema: "MahanOwji",
                        principalTable: "Appointments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppointmentTest_Tests_TestsId",
                        column: x => x.TestsId,
                        principalSchema: "MahanOwji",
                        principalTable: "Tests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "MahanOwji",
                table: "Genders",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("0d66405d-a61e-47cf-8948-9e7bb160030d"), "زن" },
                    { new Guid("936ea668-2a28-4675-86c6-f57a9d2893ea"), "مرد" }
                });

            migrationBuilder.InsertData(
                schema: "MahanOwji",
                table: "Tests",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("082b2f56-5d14-4f44-8d22-aa240827cde1"), "این آزمایش مقدار اسید اوریک در خون را اندازه‌گیری می‌کند و ممکن است به تشخیص مشکلات مرتبط با نقرس کمک کند", "آزمایش اسید اوریک (Uric Acid)" },
                    { new Guid("1342e429-9be1-445f-821b-ce8dd4342b8c"), "این آزمایش میزان کلسترول در خون را اندازه‌گیری کرده و ممکن است به ارزیابی خطر ابتلا به بیماری‌های قلبی کمک کند", "آزمایش کلسترول (Cholesterol)" },
                    { new Guid("13f1cc9e-ea43-4d47-8660-ba111e052479"), "این آزمایش فعالیت آنزیم آمیلاز را اندازه‌گیری می‌کند که به تشخیص برخی مشکلات در لاپاره یا پانکراس کمک می‌کند", "آزمایش آمیلاز (Amylase)" },
                    { new Guid("266b5d36-4900-45ea-bec8-8568ae99e051"), "این آزمایش سطح پروتئین واکنش التهابی را اندازه‌گیری می‌کند و در تشخیص التهاب‌ها و بیماری‌های التهابی مفید است", "آزمایش CRP (پروتئین واکنش التهابی)" },
                    { new Guid("37c40d0c-4c5d-4df0-92e8-498f42436093"), "این آزمایش یک مجموعه جامع از آزمایش‌های شیمیایی را انجام می‌دهد تا وضعیت کلی سلامت افراد را ارزیابی کند", "آزمایش کلیت (Comprehensive Metabolic Panel)" },
                    { new Guid("496d79ff-f13e-432b-9406-83f57adcc3f3"), " این آزمایش سطح گلوکز یا قند خون را اندازه‌گیری می‌کند و برای تشخیص دیابت استفاده می‌شود", "آزمایش گلوکز (Glucose)" },
                    { new Guid("86c53e3e-c303-4add-ad30-abe74d963219"), "این آزمایش میزان هورمون‌های تیروئید را بررسی می‌کند و مشکلات در عملکرد تیروئید را تشخیص می‌دهد", "آزمایش هورمون تیروئید (Thyroid Hormones)" },
                    { new Guid("92e36d7d-fe9e-4105-8736-720e939c7a2c"), "این آزمایش مقدار آهن در خون را اندازه‌گیری می‌کند و مشکلات مرتبط با کم‌خونی یا افزایش آهن را تشخیص می‌دهد", "آزمایش آهن (Iron)" },
                    { new Guid("9311e9be-0f29-43e5-9413-85fba068f980"), "این آزمایش میزان سلول‌های قرمز خون را در مقدار کل خون اندازه‌گیری می‌کند", "آزمایش هماتوکریت (Hematocrit)" },
                    { new Guid("aeb9ce4c-cc9c-400c-b1c7-1d7dd0fe345f"), "این آزمایش فعالیت آنزیم‌های کبدی را بررسی می‌کند و به تشخیص مشکلات کبدی مانند التهاب یا آسیب به کبد کمک می‌کند", "آزمایش آنزیم‌های کبدی (Liver Enzymes)" },
                    { new Guid("c2e0bae8-2b4d-401f-a76b-fcd46aec7dcb"), "این آزمایش مخلوط ادرار را بررسی می‌کند و ممکن است به تشخیص برخی مشکلات کلیه یا دیگر مشکلات سلامتی کمک کند", "آزمایش ادرار (Urinalysis)" },
                    { new Guid("c58c59b2-2a27-4579-8144-c144a5ae6618"), " این آزمایش فشار خون را اندازه‌گیری می‌کند و در ارزیابی سلامت قلب و عروق مفید است", "آزمایش فشار خون (Blood Pressure)" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DoctorId",
                schema: "MahanOwji",
                table: "Appointments",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_NurseId",
                schema: "MahanOwji",
                table: "Appointments",
                column: "NurseId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatientId",
                schema: "MahanOwji",
                table: "Appointments",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentTest_TestsId",
                schema: "MahanOwji",
                table: "AppointmentTest",
                column: "TestsId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_UserId",
                schema: "MahanOwji",
                table: "Doctors",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Nurses_UserId",
                schema: "MahanOwji",
                table: "Nurses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientMedication_PatientsId",
                schema: "MahanOwji",
                table: "PatientMedication",
                column: "PatientsId");

            migrationBuilder.CreateIndex(
                name: "IX_patients_UserId",
                schema: "MahanOwji",
                table: "patients",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_GenderId",
                schema: "MahanOwji",
                table: "Users",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_IdentityCode",
                schema: "MahanOwji",
                table: "Users",
                column: "IdentityCode",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppointmentTest",
                schema: "MahanOwji");

            migrationBuilder.DropTable(
                name: "PatientMedication",
                schema: "MahanOwji");

            migrationBuilder.DropTable(
                name: "Appointments",
                schema: "MahanOwji");

            migrationBuilder.DropTable(
                name: "Tests",
                schema: "MahanOwji");

            migrationBuilder.DropTable(
                name: "Medications",
                schema: "MahanOwji");

            migrationBuilder.DropTable(
                name: "Doctors",
                schema: "MahanOwji");

            migrationBuilder.DropTable(
                name: "Nurses",
                schema: "MahanOwji");

            migrationBuilder.DropTable(
                name: "patients",
                schema: "MahanOwji");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "MahanOwji");

            migrationBuilder.DropTable(
                name: "Genders",
                schema: "MahanOwji");
        }
    }
}
