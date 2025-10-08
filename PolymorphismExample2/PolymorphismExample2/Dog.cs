using System;

public class Dog: Animal
{
	public Dog() : base()
	{
	}
	public override void Speak()
	{
		Console.WriteLine("The dog barks.");
	}
}
