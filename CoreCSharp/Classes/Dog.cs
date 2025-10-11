using System;
namespace csharp.training.congruent.classes
{
public class Dog: Animal
{

	public Dog() : base()
	{
	}

        public Dog(String name)
        {
            _name = name;
        }

        public override void Speak()
	{
		Console.WriteLine("The dog barks.");
	}
}
}