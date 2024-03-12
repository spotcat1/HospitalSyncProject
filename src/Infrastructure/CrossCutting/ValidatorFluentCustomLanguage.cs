
namespace Infrastructure.CrossCutting
{
    public class ValidatorFluentCustomLanguage:FluentValidation.Resources.LanguageManager
    {
        public ValidatorFluentCustomLanguage()
        {
            Culture = new System.Globalization.CultureInfo("fa-IR");

            AddTranslation("fa", "NotEmptyValidator", "{PropertyName}   الزامی میباشد");
        }
    }
}
