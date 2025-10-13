using System;
using System.Collections.Generic;

namespace OOPPrinciplesDemo
{
    //Abstraction via Interface
    public interface IPet
    {
        void Play();
    }

    //Abstraction via Abstract Base Class
    public abstract class Animal
    {
        //Encapsulation
        private string _name;

        public string Name
        {
            get => _name;
            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty.");
                _name = value;
            }
        }

        protected Animal(string name) => Name = name;

        //Polymorphism (Run-time)
        // Derived classes must implement their specific sound
        public abstract void MakeSound();

        // Encapsulated behavior: safe way to feed an animal
        public void Feed(int grams)
        {
            if (grams <= 0) throw new ArgumentOutOfRangeException(nameof(grams));
            Console.WriteLine($"{Name} eats {grams}g of food.");
        }

        // Polymorphism (Compile-time) 
        // Method overloading: two ways to call Feed
        public void Feed() => Feed(50); // default portion
    }

    
    public class Dog : Animal, IPet
    {
        public Dog(string name) : base(name) { }

        public override void MakeSound() => Console.WriteLine($"{Name}: Woof!");
        public void Play() => Console.WriteLine($"{Name} fetches the ball.");
    }

    public class Cat : Animal, IPet
    {
        public Cat(string name) : base(name) { }

        public override void MakeSound() => Console.WriteLine($"{Name}: Meow!");
        public void Play() => Console.WriteLine($"{Name} chases the laser.");
    }

    public static class Program
    {
        public static void Main()
        {
            
            List<Animal> animals = new() { new Dog("Bruno"), new Cat("Misty") };

            foreach (var a in animals)
            {
                a.MakeSound();
                a.Feed();     
                a.Feed(100);  
            }
                        
            List<IPet> pets = new() { (IPet)animals[0], (IPet)animals[1] };
            foreach (var pet in pets)
            {
                pet.Play();
            }

            
        }
    }
}