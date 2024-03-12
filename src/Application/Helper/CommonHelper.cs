
using System.Globalization;

namespace Application.Helper
{
    public static class CommonHelper
    {
        public static DateTime ConvertToMiladi(this string PersianDate)
        {
            return DateTime.Parse(PersianDate, new CultureInfo("fa-IR"));
        }


        public static string ConvertToPersiandate(this DateTime date)
        {
            return date.ToString("yyyy/MM/dd", new CultureInfo("fa-IR"));
        }
    }
}
