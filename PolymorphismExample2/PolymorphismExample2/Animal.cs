using System;

public class Animal
{
	public Animal()
	{
	}
	public virtual void Speak()
	{
		Console.WriteLine("The animal makes a sound.");
    }

	public void SayType()
	{
			Console.WriteLine("I am : "+this.GetType().ToString());
    }
}
