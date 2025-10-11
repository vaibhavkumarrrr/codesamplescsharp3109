using System;
namespace csharp.training.congruent.classes
{
public class Animal
{
        protected string _name;
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}
    public Animal()
	{
			_name = string.Empty;
	}
	public virtual void Speak()
	{
		Console.WriteLine("The animal makes a sound.");
    }

	public void SayType()
	{
			Console.WriteLine("I am : "+this.GetType().ToString());
    }
        public void Announce()
        {
            Console.WriteLine($"I am : {this.Name} and I am {this.GetType().ToString()}");
        }
    }
}