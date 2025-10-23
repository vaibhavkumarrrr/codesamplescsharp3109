using csharp.training.congruent.enums;
namespace csharp.training.congruent.apps
{
    internal class Program
    {
        static void Main(string[] _)
        {
            Days meetingDays = Days.Monday | Days.Wednesday | Days.Friday | Days.Tuesday ;
            Console.WriteLine(meetingDays);
            Days workingFromHomeDays = Days.Thursday | Days.Friday;
            Console.WriteLine($"Join a meeting by phone on {meetingDays & workingFromHomeDays}");
            bool isMeetingOnTuesday = (meetingDays & Days.Tuesday) == Days.Tuesday;
            Console.WriteLine($"Is there a meeting on Tuesday: {isMeetingOnTuesday}");
            bool isMeetingOnWeekEnd = ((meetingDays & Days.Saturday) == Days.Saturday) || ((meetingDays & Days.Sunday) == Days.Sunday);
            Console.WriteLine($"Is there a meeting on Weekend: {isMeetingOnWeekEnd}");

        }
    }
}
