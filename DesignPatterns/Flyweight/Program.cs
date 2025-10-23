﻿// EN: Flyweight Design Pattern
//
// Intent: Lets you fit more objects into the available amount of RAM by sharing
// common parts of state between multiple objects, instead of keeping all of the
// data in each object.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
// EN: Use Json.NET library, you can download it from NuGet Package Manager
namespace csharp.training.congruent.apps.patterns
{
    // EN: The Flyweight stores a common portion of the state (also called
    // intrinsic state) that belongs to multiple real business entities. The
    // Flyweight accepts the rest of the state (extrinsic state, unique for each
    // entity) via its method parameters.
    public class Flyweight(Car car)
    {
        private readonly Car _sharedState = car;

        public void Operation(Car uniqueState)
        {
            string s = JsonSerializer.Serialize(this._sharedState);
            string u = JsonSerializer.Serialize(uniqueState);
            Console.WriteLine($"Flyweight: Displaying shared {s} and unique {u} state.");
        }
    }

    // EN: The Flyweight Factory creates and manages the Flyweight objects. It
    // ensures that flyweights are shared correctly. When the client requests a
    // flyweight, the factory either returns an existing instance or creates a
    // new one, if it doesn't exist yet.
    public class FlyweightFactory
    {
        private readonly List<Tuple<Flyweight, string>> flyweights = [];

        public FlyweightFactory(params Car[] args)
        {
            foreach (var elem in args)
            {
                flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(elem), GetKey(elem)));
            }
        }

        // EN: Returns a Flyweight's string hash for a given state.
        public static string GetKey(Car key)
        {
            List<string> elements = [key.Model, key.Color, key.Company];

            if (key.Owner != null && key.Number != null)
            {
                elements.Add(key.Number);
                elements.Add(key.Owner);
            }

            elements.Sort();

            return string.Join("_", elements);
        }

        // EN: Returns an existing Flyweight with a given state or creates a new
        // one.
        public Flyweight GetFlyweight(Car sharedState)
        {
            string key = GetKey(sharedState);

            if (!flyweights.Any(t => t.Item2 == key))
            //if (flyweights.Where(t => t.Item2 == key).Count() == 0)
            {
                Console.WriteLine("FlyweightFactory: Can't find a flyweight, creating new one.");
                this.flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(sharedState), key));
            }
            else
            {
                Console.WriteLine("FlyweightFactory: Reusing existing flyweight.");
            }
            return this.flyweights.Where(t => t.Item2 == key).FirstOrDefault().Item1;
        }

        public void ListFlyweights()
        {
            var count = flyweights.Count;
            Console.WriteLine($"\nFlyweightFactory: I have {count} flyweights:");
            foreach (var flyweight in flyweights)
            {
                Console.WriteLine(flyweight.Item2);
            }
        }
    }

    public class Car
    {
        public string Owner { get; set; }

        public string Number { get; set; }

        public string Company { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }
    }

    class Program
    {
        static void Main(string[] _)
        {
            // EN: The client code usually creates a bunch of pre-populated
            // flyweights in the initialization stage of the application.
            var factory = new FlyweightFactory(
                new Car { Company = "Chevrolet", Model = "Camaro2018", Color = "pink" },
                new Car { Company = "Mercedes Benz", Model = "C300", Color = "black" },
                new Car { Company = "Mercedes Benz", Model = "C500", Color = "red" },
                new Car { Company = "BMW", Model = "M5", Color = "red" },
                new Car { Company = "BMW", Model = "X6", Color = "white" }
            );
            factory.ListFlyweights();

            AddCarToPoliceDatabase(factory, new Car {
                Number = "CL234IR",
                Owner = "James Doe",
                Company = "BMW",
                Model = "M5",
                Color = "red"
            });

            AddCarToPoliceDatabase(factory, new Car {
                Number = "CL234IR",
                Owner = "James Doe",
                Company = "BMW",
                Model = "X1",
                Color = "red"
            });

            factory.ListFlyweights();
        }

        public static void AddCarToPoliceDatabase(FlyweightFactory factory, Car car)
        {
            Console.WriteLine("\nClient: Adding a car to database.");

            var flyweight = factory.GetFlyweight(new Car {
                Color = car.Color,
                Model = car.Model,
                Company = car.Company
            });

            // EN: The client code either stores or calculates extrinsic state
            // and passes it to the flyweight's methods.
            flyweight.Operation(car);
        }
    }
}
