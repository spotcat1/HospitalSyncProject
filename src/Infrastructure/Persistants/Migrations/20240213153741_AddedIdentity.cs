using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Persistants.Migrations
{
    /// <inheritdoc />
    public partial class AddedIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("0d66405d-a61e-47cf-8948-9e7bb160030d"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("936ea668-2a28-4675-86c6-f57a9d2893ea"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("082b2f56-5d14-4f44-8d22-aa240827cde1"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("1342e429-9be1-445f-821b-ce8dd4342b8c"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("13f1cc9e-ea43-4d47-8660-ba111e052479"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("266b5d36-4900-45ea-bec8-8568ae99e051"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("37c40d0c-4c5d-4df0-92e8-498f42436093"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("496d79ff-f13e-432b-9406-83f57adcc3f3"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("86c53e3e-c303-4add-ad30-abe74d963219"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("92e36d7d-fe9e-4105-8736-720e939c7a2c"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("9311e9be-0f29-43e5-9413-85fba068f980"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("aeb9ce4c-cc9c-400c-b1c7-1d7dd0fe345f"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("c2e0bae8-2b4d-401f-a76b-fcd46aec7dcb"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("c58c59b2-2a27-4579-8144-c144a5ae6618"));

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                schema: "MahanOwji",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                schema: "MahanOwji",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Fullname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                schema: "MahanOwji",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "MahanOwji",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                schema: "MahanOwji",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "MahanOwji",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                schema: "MahanOwji",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "MahanOwji",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                schema: "MahanOwji",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "MahanOwji",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "MahanOwji",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                schema: "MahanOwji",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "MahanOwji",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "MahanOwji",
                table: "Genders",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("b470d247-1726-4238-a25a-1937b6415ee2"), "مرد" },
                    { new Guid("feb236d1-b270-4fb1-8ac8-14976e90780b"), "زن" }
                });

            migrationBuilder.InsertData(
                schema: "MahanOwji",
                table: "Tests",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("07d49e29-e56e-4895-ac3d-d78a63932e74"), "این آزمایش سطح پروتئین واکنش التهابی را اندازه‌گیری می‌کند و در تشخیص التهاب‌ها و بیماری‌های التهابی مفید است", "آزمایش CRP (پروتئین واکنش التهابی)" },
                    { new Guid("23cd8fb4-ed44-4ab8-9052-30e50d9c922e"), "این آزمایش یک مجموعه جامع از آزمایش‌های شیمیایی را انجام می‌دهد تا وضعیت کلی سلامت افراد را ارزیابی کند", "آزمایش کلیت (Comprehensive Metabolic Panel)" },
                    { new Guid("4e568e86-202f-4063-b119-f44c73537b4b"), "این آزمایش مقدار اسید اوریک در خون را اندازه‌گیری می‌کند و ممکن است به تشخیص مشکلات مرتبط با نقرس کمک کند", "آزمایش اسید اوریک (Uric Acid)" },
                    { new Guid("5d2a7ca9-d7a2-4b77-b7e8-6c2b608003ed"), "این آزمایش میزان کلسترول در خون را اندازه‌گیری کرده و ممکن است به ارزیابی خطر ابتلا به بیماری‌های قلبی کمک کند", "آزمایش کلسترول (Cholesterol)" },
                    { new Guid("6e2a9659-031e-4057-9416-9c3fb8856535"), "این آزمایش میزان هورمون‌های تیروئید را بررسی می‌کند و مشکلات در عملکرد تیروئید را تشخیص می‌دهد", "آزمایش هورمون تیروئید (Thyroid Hormones)" },
                    { new Guid("78babc09-42dd-4631-a8fb-18602b1d7ac6"), " این آزمایش فشار خون را اندازه‌گیری می‌کند و در ارزیابی سلامت قلب و عروق مفید است", "آزمایش فشار خون (Blood Pressure)" },
                    { new Guid("796be340-793b-4c88-a5cc-62b61da43224"), "این آزمایش میزان سلول‌های قرمز خون را در مقدار کل خون اندازه‌گیری می‌کند", "آزمایش هماتوکریت (Hematocrit)" },
                    { new Guid("b40251fd-5012-4ee9-93b5-f77e3dae8c33"), " این آزمایش سطح گلوکز یا قند خون را اندازه‌گیری می‌کند و برای تشخیص دیابت استفاده می‌شود", "آزمایش گلوکز (Glucose)" },
                    { new Guid("b4a7f2da-2343-4f9f-82f0-462335dfe3a8"), "این آزمایش فعالیت آنزیم آمیلاز را اندازه‌گیری می‌کند که به تشخیص برخی مشکلات در لاپاره یا پانکراس کمک می‌کند", "آزمایش آمیلاز (Amylase)" },
                    { new Guid("c518d40e-5b3a-4822-a415-3004da995101"), "این آزمایش فعالیت آنزیم‌های کبدی را بررسی می‌کند و به تشخیص مشکلات کبدی مانند التهاب یا آسیب به کبد کمک می‌کند", "آزمایش آنزیم‌های کبدی (Liver Enzymes)" },
                    { new Guid("ce847b11-2330-4c6d-aeb4-82492165050f"), "این آزمایش مقدار آهن در خون را اندازه‌گیری می‌کند و مشکلات مرتبط با کم‌خونی یا افزایش آهن را تشخیص می‌دهد", "آزمایش آهن (Iron)" },
                    { new Guid("de6eba7b-59f0-493f-987d-57e125d510cf"), "این آزمایش مخلوط ادرار را بررسی می‌کند و ممکن است به تشخیص برخی مشکلات کلیه یا دیگر مشکلات سلامتی کمک کند", "آزمایش ادرار (Urinalysis)" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                schema: "MahanOwji",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "MahanOwji",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                schema: "MahanOwji",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                schema: "MahanOwji",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                schema: "MahanOwji",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "MahanOwji",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "MahanOwji",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims",
                schema: "MahanOwji");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims",
                schema: "MahanOwji");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins",
                schema: "MahanOwji");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles",
                schema: "MahanOwji");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens",
                schema: "MahanOwji");

            migrationBuilder.DropTable(
                name: "AspNetRoles",
                schema: "MahanOwji");

            migrationBuilder.DropTable(
                name: "AspNetUsers",
                schema: "MahanOwji");

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("b470d247-1726-4238-a25a-1937b6415ee2"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("feb236d1-b270-4fb1-8ac8-14976e90780b"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("07d49e29-e56e-4895-ac3d-d78a63932e74"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("23cd8fb4-ed44-4ab8-9052-30e50d9c922e"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("4e568e86-202f-4063-b119-f44c73537b4b"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("5d2a7ca9-d7a2-4b77-b7e8-6c2b608003ed"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("6e2a9659-031e-4057-9416-9c3fb8856535"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("78babc09-42dd-4631-a8fb-18602b1d7ac6"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("796be340-793b-4c88-a5cc-62b61da43224"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("b40251fd-5012-4ee9-93b5-f77e3dae8c33"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("b4a7f2da-2343-4f9f-82f0-462335dfe3a8"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("c518d40e-5b3a-4822-a415-3004da995101"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("ce847b11-2330-4c6d-aeb4-82492165050f"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("de6eba7b-59f0-493f-987d-57e125d510cf"));

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
        }
    }
}
