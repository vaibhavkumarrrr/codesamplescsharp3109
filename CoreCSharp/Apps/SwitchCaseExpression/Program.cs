using csharp.training.congruent.enums;
namespace csharp.training.congruent.apps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Switch Case Expression to print holidays based on month
            // Uses C# 13.0 feature: switch expression with patterns
           // Reference: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/switch-expression
            static void PrintHoliday(Month month) => Console.WriteLine(month switch
            {
                Month.January => $"{month} - We have Pongal.",
                Month.February => $"{month} - We have Maha Shivaratri.",
                Month.March => $"{month} - We have Holi.",
                Month.April => $"{month} - We have Tamil New Year.",
                Month.May => $"{month} - We have Labour Day.",
                Month.June => $"{month} - We have World Environment Day.",
                Month.July => $"{month} - We have US Independence Day.",
                Month.August => $"{month} - We have Independence Day.",
                Month.September => $"{month} - We have Teacher's Day.",
                Month.October => $"{month} - We have Gandhi Jayanthi and Diwali.",
                Month.November => $"{month} - We have Thanksgiving.",
                Month.December => $"{month} - We have Christmas.",
                _ => "Unknown Month"
            });
            // Use Enum.GetValues to iterate through all months

            foreach (Month month in Enum.GetValues(typeof(Month)))
            {
                PrintHoliday(month);
            }

        }
    }
}
