using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Persistants.Migrations
{
    /// <inheritdoc />
    public partial class added_phonenumber_constrant : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                schema: "MahanOwji",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                schema: "MahanOwji",
                table: "Genders",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("5d16bb80-4856-4145-b33f-f95bfb70ef64"), "زن" },
                    { new Guid("677da5c5-0679-4041-921b-808a6d34226d"), "مرد" }
                });

            migrationBuilder.InsertData(
                schema: "MahanOwji",
                table: "Tests",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("045517e5-99ca-475b-acde-488d2d85187a"), "این آزمایش مقدار اسید اوریک در خون را اندازه‌گیری می‌کند و ممکن است به تشخیص مشکلات مرتبط با نقرس کمک کند", "آزمایش اسید اوریک (Uric Acid)" },
                    { new Guid("27061c24-2949-4c10-b2d6-6bbe5a94bfa0"), "این آزمایش مخلوط ادرار را بررسی می‌کند و ممکن است به تشخیص برخی مشکلات کلیه یا دیگر مشکلات سلامتی کمک کند", "آزمایش ادرار (Urinalysis)" },
                    { new Guid("2c4bba50-3040-487c-9e2c-e518fd8980cc"), " این آزمایش فشار خون را اندازه‌گیری می‌کند و در ارزیابی سلامت قلب و عروق مفید است", "آزمایش فشار خون (Blood Pressure)" },
                    { new Guid("3ad43d97-a7be-431c-8ddc-5924ffa713c7"), "این آزمایش سطح پروتئین واکنش التهابی را اندازه‌گیری می‌کند و در تشخیص التهاب‌ها و بیماری‌های التهابی مفید است", "آزمایش CRP (پروتئین واکنش التهابی)" },
                    { new Guid("45e9bf0e-9c68-4d69-b800-0da2f1bbf058"), "این آزمایش میزان کلسترول در خون را اندازه‌گیری کرده و ممکن است به ارزیابی خطر ابتلا به بیماری‌های قلبی کمک کند", "آزمایش کلسترول (Cholesterol)" },
                    { new Guid("6f4717f3-7e29-4deb-94c3-00153681cc04"), "این آزمایش فعالیت آنزیم آمیلاز را اندازه‌گیری می‌کند که به تشخیص برخی مشکلات در لاپاره یا پانکراس کمک می‌کند", "آزمایش آمیلاز (Amylase)" },
                    { new Guid("8a1164cb-32e3-4454-9c0a-21c89892ceec"), " این آزمایش سطح گلوکز یا قند خون را اندازه‌گیری می‌کند و برای تشخیص دیابت استفاده می‌شود", "آزمایش گلوکز (Glucose)" },
                    { new Guid("9eb4c8d3-443b-441a-acbb-08e07ae8ca5a"), "این آزمایش میزان هورمون‌های تیروئید را بررسی می‌کند و مشکلات در عملکرد تیروئید را تشخیص می‌دهد", "آزمایش هورمون تیروئید (Thyroid Hormones)" },
                    { new Guid("d20b4941-41d9-4668-8108-3f23ec72c4fb"), "این آزمایش فعالیت آنزیم‌های کبدی را بررسی می‌کند و به تشخیص مشکلات کبدی مانند التهاب یا آسیب به کبد کمک می‌کند", "آزمایش آنزیم‌های کبدی (Liver Enzymes)" },
                    { new Guid("e0a560d3-871a-4216-9399-5366dddcb82a"), "این آزمایش یک مجموعه جامع از آزمایش‌های شیمیایی را انجام می‌دهد تا وضعیت کلی سلامت افراد را ارزیابی کند", "آزمایش کلیت (Comprehensive Metabolic Panel)" },
                    { new Guid("e2ebc877-f882-4abd-bdd5-3e798529a920"), "این آزمایش مقدار آهن در خون را اندازه‌گیری می‌کند و مشکلات مرتبط با کم‌خونی یا افزایش آهن را تشخیص می‌دهد", "آزمایش آهن (Iron)" },
                    { new Guid("eb682596-2783-4923-839c-b3f1709be53b"), "این آزمایش میزان سلول‌های قرمز خون را در مقدار کل خون اندازه‌گیری می‌کند", "آزمایش هماتوکریت (Hematocrit)" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PhoneNumber",
                schema: "MahanOwji",
                table: "AspNetUsers",
                column: "PhoneNumber",
                unique: true,
                filter: "[PhoneNumber] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PhoneNumber",
                schema: "MahanOwji",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("5d16bb80-4856-4145-b33f-f95bfb70ef64"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("677da5c5-0679-4041-921b-808a6d34226d"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("045517e5-99ca-475b-acde-488d2d85187a"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("27061c24-2949-4c10-b2d6-6bbe5a94bfa0"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("2c4bba50-3040-487c-9e2c-e518fd8980cc"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("3ad43d97-a7be-431c-8ddc-5924ffa713c7"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("45e9bf0e-9c68-4d69-b800-0da2f1bbf058"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("6f4717f3-7e29-4deb-94c3-00153681cc04"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("8a1164cb-32e3-4454-9c0a-21c89892ceec"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("9eb4c8d3-443b-441a-acbb-08e07ae8ca5a"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("d20b4941-41d9-4668-8108-3f23ec72c4fb"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("e0a560d3-871a-4216-9399-5366dddcb82a"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("e2ebc877-f882-4abd-bdd5-3e798529a920"));

            migrationBuilder.DeleteData(
                schema: "MahanOwji",
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("eb682596-2783-4923-839c-b3f1709be53b"));

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                schema: "MahanOwji",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

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
        }
    }
}
