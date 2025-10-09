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
                Month.January => "We have Pongal.",
                Month.February => "We have Maha Shivaratri.",
                Month.March => "We have Holi.",
                Month.April => "We have Tamil New Year.",
                Month.May => "We have Labour Day.",
                Month.June => "We have World Environment Day.",
                Month.July => "We have US Independence Day.",
                Month.August => "We have Independence Day.",
                Month.September => "We have Teacher's Day.",
                Month.October => "We have Gandhi Jayanthi and Diwali.",
                Month.November => "We have Thanksgiving.",
                Month.December => "We have Christmas.",
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
