using System;
namespace csharp.training.congruent.classes
{
public class Cat: Animal
{
	public Cat() : base()
	{
	}
	public override void Speak()
	{
		Console.WriteLine("The cat meows.");
	}
}
}