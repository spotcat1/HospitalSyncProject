

namespace Infrastructure.Persistants.Configurations
{
    internal class TestEntityConfiguration : IEntityTypeConfiguration<TestEntity>
    {
        public void Configure(EntityTypeBuilder<TestEntity> builder)
        {
            builder.ToTable("Tests");

            builder.HasKey(x => x.Id);


            builder.Property(x => x.Name)
                .HasMaxLength(500)
                .IsRequired();

            builder.Property(x => x.Description)
                .HasMaxLength(1000)
                .IsRequired(false);


            builder.HasData(new TestEntity
            {
                Id = Guid.NewGuid(),
                Name = "آزمایش هماتوکریت (Hematocrit)",
                Description = "این آزمایش میزان سلول‌های قرمز خون را در مقدار کل خون اندازه‌گیری می‌کند"
            }, new TestEntity
            {
                Id = Guid.NewGuid(),
                Name = "آزمایش گلوکز (Glucose)",
                Description = " این آزمایش سطح گلوکز یا قند خون را اندازه‌گیری می‌کند و برای تشخیص دیابت استفاده می‌شود"
            }, new TestEntity
            {
                Id = Guid.NewGuid(),
                Name = "آزمایش کلسترول (Cholesterol)",
                Description = "این آزمایش میزان کلسترول در خون را اندازه‌گیری کرده و ممکن است به ارزیابی خطر ابتلا به بیماری‌های قلبی کمک کند"
            }, new TestEntity
            {
                Id = Guid.NewGuid(),
                Name = "آزمایش هورمون تیروئید (Thyroid Hormones)",
                Description = "این آزمایش میزان هورمون‌های تیروئید را بررسی می‌کند و مشکلات در عملکرد تیروئید را تشخیص می‌دهد"
            }, new TestEntity
            {
                Id = Guid.NewGuid(),
                Name= "آزمایش آهن (Iron)",
                Description= "این آزمایش مقدار آهن در خون را اندازه‌گیری می‌کند و مشکلات مرتبط با کم‌خونی یا افزایش آهن را تشخیص می‌دهد"
            }, new TestEntity
            {
                Id= Guid.NewGuid(),
                Name= "آزمایش ادرار (Urinalysis)",
                Description= "این آزمایش مخلوط ادرار را بررسی می‌کند و ممکن است به تشخیص برخی مشکلات کلیه یا دیگر مشکلات سلامتی کمک کند"
            }, new TestEntity
            {
                Id=Guid.NewGuid(),
                Name= "آزمایش آمیلاز (Amylase)",
                Description= "این آزمایش فعالیت آنزیم آمیلاز را اندازه‌گیری می‌کند که به تشخیص برخی مشکلات در لاپاره یا پانکراس کمک می‌کند"
            }, new TestEntity
            {
                Id=Guid.NewGuid(),
                Name= "آزمایش CRP (پروتئین واکنش التهابی)",
                Description= "این آزمایش سطح پروتئین واکنش التهابی را اندازه‌گیری می‌کند و در تشخیص التهاب‌ها و بیماری‌های التهابی مفید است"
            }, new TestEntity
            {
                Id=Guid.NewGuid(),
                Name= "آزمایش اسید اوریک (Uric Acid)",
                Description= "این آزمایش مقدار اسید اوریک در خون را اندازه‌گیری می‌کند و ممکن است به تشخیص مشکلات مرتبط با نقرس کمک کند"
            }, new TestEntity
            {
                Id=Guid.NewGuid(),
                Name= "آزمایش آنزیم‌های کبدی (Liver Enzymes)",
                Description= "این آزمایش فعالیت آنزیم‌های کبدی را بررسی می‌کند و به تشخیص مشکلات کبدی مانند التهاب یا آسیب به کبد کمک می‌کند"
            }, new TestEntity
            {
                Id=Guid.NewGuid(),
                Name= "آزمایش فشار خون (Blood Pressure)",
                Description= " این آزمایش فشار خون را اندازه‌گیری می‌کند و در ارزیابی سلامت قلب و عروق مفید است"
            }, new TestEntity
            {
                Id=Guid.NewGuid(),
                Name= "آزمایش کلیت (Comprehensive Metabolic Panel)",
                Description= "این آزمایش یک مجموعه جامع از آزمایش‌های شیمیایی را انجام می‌دهد تا وضعیت کلی سلامت افراد را ارزیابی کند"
            });











            builder
                .HasMany(x => x.Appointments)
                .WithMany(x => x.Tests)
                .UsingEntity(x =>
                {
                    x.ToTable("AppointmentTest");
                });

        }
    }
}
