namespace csharp.training.congruent.enums 
{
	public enum Days : ushort
	{
		Monday = 1;
		Tuesday = 2; 
		Wednesday = 4;
		Thursday = 8;
		Friday = 16;
		Saturday = 32;
		Sunday = 64;
		Weekday = Monday | Tuesday | Wednesday | Thursday | Friday;
		Weekend = Saturday | Sunday;
		All = Weekday | Weekend;
    }

} 