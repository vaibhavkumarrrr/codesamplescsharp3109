using System;
namespace csharp.training.congruent.classes
{
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
}