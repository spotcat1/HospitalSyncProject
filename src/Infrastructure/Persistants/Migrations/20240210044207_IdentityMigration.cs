using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Persistants.Migrations
{
    /// <inheritdoc />
    public partial class IdentityMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("391c456b-123b-4589-af09-5eab0a159a7b"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("59a0835e-c551-4df2-8494-bdf36dba6c1e"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("0ee63ab1-595d-406f-8014-2f4d6354a8c9"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("23f07538-e7c6-40bf-961c-f455d355a11b"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("275dc840-57c5-42e5-aedd-73a58ed73827"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("32d33777-94a5-42c6-845a-3057be515d1e"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("5e6e8920-018a-4dc7-b725-837dab0e0414"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("75542cd0-dd95-4d91-8f73-283884008084"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("9cdfbeae-77a8-4c60-ae2b-d429ea5edfb0"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("a90429a9-bcf7-48b5-8e9a-1d9b387ec737"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("c656c0eb-8a7b-4372-824f-ae00353c964a"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("c8c7b4d8-91e6-452f-9251-0d0140644e8c"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("f139af21-a580-4aab-8cee-7383088e6651"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("f8395ee6-4c13-4f0b-af0d-e22b12d598f4"));

            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                schema: "MahanOwji",
                table: "Users",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                schema: "MahanOwji",
                table: "Users",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

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
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
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
                    { new Guid("9728f42a-9914-4399-937f-c3749efc2703"), "زن" },
                    { new Guid("a0465add-8b12-4d42-b3c5-f91dc6177227"), "مرد" }
                });

            migrationBuilder.InsertData(
                schema: "MahanOwji",
                table: "Tests",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("040dca85-7c59-4c49-a4db-459b966e5533"), "این آزمایش سطح پروتئین واکنش التهابی را اندازه‌گیری می‌کند و در تشخیص التهاب‌ها و بیماری‌های التهابی مفید است", "آزمایش CRP (پروتئین واکنش التهابی)" },
                    { new Guid("1a64ef8b-d105-4b97-ba3d-1c63ca6665f6"), "این آزمایش فعالیت آنزیم آمیلاز را اندازه‌گیری می‌کند که به تشخیص برخی مشکلات در لاپاره یا پانکراس کمک می‌کند", "آزمایش آمیلاز (Amylase)" },
                    { new Guid("28d0d9ad-55dd-47b2-9b36-d54f8b0e717a"), "این آزمایش میزان کلسترول در خون را اندازه‌گیری کرده و ممکن است به ارزیابی خطر ابتلا به بیماری‌های قلبی کمک کند", "آزمایش کلسترول (Cholesterol)" },
                    { new Guid("4ceccd31-9828-425a-bb2f-ec5844fe7e10"), "این آزمایش فعالیت آنزیم‌های کبدی را بررسی می‌کند و به تشخیص مشکلات کبدی مانند التهاب یا آسیب به کبد کمک می‌کند", "آزمایش آنزیم‌های کبدی (Liver Enzymes)" },
                    { new Guid("621dda4e-f377-4539-9095-da659c6424a3"), "این آزمایش میزان هورمون‌های تیروئید را بررسی می‌کند و مشکلات در عملکرد تیروئید را تشخیص می‌دهد", "آزمایش هورمون تیروئید (Thyroid Hormones)" },
                    { new Guid("64411787-2f78-4e40-829b-0d52667ccc94"), " این آزمایش فشار خون را اندازه‌گیری می‌کند و در ارزیابی سلامت قلب و عروق مفید است", "آزمایش فشار خون (Blood Pressure)" },
                    { new Guid("71bb63bb-a907-4617-a78a-661bf2f01fae"), "این آزمایش مقدار آهن در خون را اندازه‌گیری می‌کند و مشکلات مرتبط با کم‌خونی یا افزایش آهن را تشخیص می‌دهد", "آزمایش آهن (Iron)" },
                    { new Guid("76bd529a-3c57-43ec-b754-a2213f68de06"), "این آزمایش مخلوط ادرار را بررسی می‌کند و ممکن است به تشخیص برخی مشکلات کلیه یا دیگر مشکلات سلامتی کمک کند", "آزمایش ادرار (Urinalysis)" },
                    { new Guid("80e8d8ee-a2da-4f83-b6a3-2466e0f6fa04"), " این آزمایش سطح گلوکز یا قند خون را اندازه‌گیری می‌کند و برای تشخیص دیابت استفاده می‌شود", "آزمایش گلوکز (Glucose)" },
                    { new Guid("c268729e-708f-43eb-8e32-2b338a627c81"), "این آزمایش میزان سلول‌های قرمز خون را در مقدار کل خون اندازه‌گیری می‌کند", "آزمایش هماتوکریت (Hematocrit)" },
                    { new Guid("cabf1cf9-1bde-495b-844e-51bf41c3c7f1"), "این آزمایش یک مجموعه جامع از آزمایش‌های شیمیایی را انجام می‌دهد تا وضعیت کلی سلامت افراد را ارزیابی کند", "آزمایش کلیت (Comprehensive Metabolic Panel)" },
                    { new Guid("eea41e88-7a61-4a52-88d5-09d63d399315"), "این آزمایش مقدار اسید اوریک در خون را اندازه‌گیری می‌کند و ممکن است به تشخیص مشکلات مرتبط با نقرس کمک کند", "آزمایش اسید اوریک (Uric Acid)" }
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
                keyValue: new Guid("9728f42a-9914-4399-937f-c3749efc2703"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("a0465add-8b12-4d42-b3c5-f91dc6177227"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("040dca85-7c59-4c49-a4db-459b966e5533"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("1a64ef8b-d105-4b97-ba3d-1c63ca6665f6"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("28d0d9ad-55dd-47b2-9b36-d54f8b0e717a"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("4ceccd31-9828-425a-bb2f-ec5844fe7e10"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("621dda4e-f377-4539-9095-da659c6424a3"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("64411787-2f78-4e40-829b-0d52667ccc94"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("71bb63bb-a907-4617-a78a-661bf2f01fae"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("76bd529a-3c57-43ec-b754-a2213f68de06"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("80e8d8ee-a2da-4f83-b6a3-2466e0f6fa04"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("c268729e-708f-43eb-8e32-2b338a627c81"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("cabf1cf9-1bde-495b-844e-51bf41c3c7f1"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("eea41e88-7a61-4a52-88d5-09d63d399315"));

            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                schema: "MahanOwji",
                table: "Users",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                schema: "MahanOwji",
                table: "Users",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.InsertData(
                schema: "MahanOwji",
                table: "Genders",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("391c456b-123b-4589-af09-5eab0a159a7b"), "مرد" },
                    { new Guid("59a0835e-c551-4df2-8494-bdf36dba6c1e"), "زن" }
                });

            migrationBuilder.InsertData(
                schema: "MahanOwji",
                table: "Tests",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("0ee63ab1-595d-406f-8014-2f4d6354a8c9"), "این آزمایش مخلوط ادرار را بررسی می‌کند و ممکن است به تشخیص برخی مشکلات کلیه یا دیگر مشکلات سلامتی کمک کند", "آزمایش ادرار (Urinalysis)" },
                    { new Guid("23f07538-e7c6-40bf-961c-f455d355a11b"), "این آزمایش مقدار آهن در خون را اندازه‌گیری می‌کند و مشکلات مرتبط با کم‌خونی یا افزایش آهن را تشخیص می‌دهد", "آزمایش آهن (Iron)" },
                    { new Guid("275dc840-57c5-42e5-aedd-73a58ed73827"), "این آزمایش میزان سلول‌های قرمز خون را در مقدار کل خون اندازه‌گیری می‌کند", "آزمایش هماتوکریت (Hematocrit)" },
                    { new Guid("32d33777-94a5-42c6-845a-3057be515d1e"), " این آزمایش فشار خون را اندازه‌گیری می‌کند و در ارزیابی سلامت قلب و عروق مفید است", "آزمایش فشار خون (Blood Pressure)" },
                    { new Guid("5e6e8920-018a-4dc7-b725-837dab0e0414"), "این آزمایش فعالیت آنزیم‌های کبدی را بررسی می‌کند و به تشخیص مشکلات کبدی مانند التهاب یا آسیب به کبد کمک می‌کند", "آزمایش آنزیم‌های کبدی (Liver Enzymes)" },
                    { new Guid("75542cd0-dd95-4d91-8f73-283884008084"), "این آزمایش مقدار اسید اوریک در خون را اندازه‌گیری می‌کند و ممکن است به تشخیص مشکلات مرتبط با نقرس کمک کند", "آزمایش اسید اوریک (Uric Acid)" },
                    { new Guid("9cdfbeae-77a8-4c60-ae2b-d429ea5edfb0"), "این آزمایش سطح پروتئین واکنش التهابی را اندازه‌گیری می‌کند و در تشخیص التهاب‌ها و بیماری‌های التهابی مفید است", "آزمایش CRP (پروتئین واکنش التهابی)" },
                    { new Guid("a90429a9-bcf7-48b5-8e9a-1d9b387ec737"), " این آزمایش سطح گلوکز یا قند خون را اندازه‌گیری می‌کند و برای تشخیص دیابت استفاده می‌شود", "آزمایش گلوکز (Glucose)" },
                    { new Guid("c656c0eb-8a7b-4372-824f-ae00353c964a"), "این آزمایش یک مجموعه جامع از آزمایش‌های شیمیایی را انجام می‌دهد تا وضعیت کلی سلامت افراد را ارزیابی کند", "آزمایش کلیت (Comprehensive Metabolic Panel)" },
                    { new Guid("c8c7b4d8-91e6-452f-9251-0d0140644e8c"), "این آزمایش میزان هورمون‌های تیروئید را بررسی می‌کند و مشکلات در عملکرد تیروئید را تشخیص می‌دهد", "آزمایش هورمون تیروئید (Thyroid Hormones)" },
                    { new Guid("f139af21-a580-4aab-8cee-7383088e6651"), "این آزمایش میزان کلسترول در خون را اندازه‌گیری کرده و ممکن است به ارزیابی خطر ابتلا به بیماری‌های قلبی کمک کند", "آزمایش کلسترول (Cholesterol)" },
                    { new Guid("f8395ee6-4c13-4f0b-af0d-e22b12d598f4"), "این آزمایش فعالیت آنزیم آمیلاز را اندازه‌گیری می‌کند که به تشخیص برخی مشکلات در لاپاره یا پانکراس کمک می‌کند", "آزمایش آمیلاز (Amylase)" }
                });
        }
    }
}
