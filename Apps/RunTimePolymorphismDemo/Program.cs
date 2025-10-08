// See https://aka.ms/new-console-template for more information
// Implicitly usings are enabled for this project.
// implicit Global Namespace Usings are enabled for this project.
using csharp.training.congruent.classes;
using csharp.training.congruent.samples.classes;

Console.WriteLine("Hello, World!");
new Dog().Speak();
new Animal().Speak();
Animal bruno = new Dog();
bruno.Speak(); // "The dog barks."

Animal great = new Cat();
great.Speak(); // "The cat meows."

bruno.SayType();
great.SayType();
bruno = great;
Console.WriteLine("Changing reference of bruno to great");
bruno.SayType();
bruno.Speak(); // "The cat meows."

Account a = new Account();
//a.balance = 1000000000; 
a.Balance = -300;
//Console.WriteLine(a.Balance);

Person p = new Person();
Console.WriteLine(p.FullName);
Console.WriteLine(p.ToString());

p.FirstName = "Rajesh";
p.LastName = "Singh";
p.Introduce();

p.FirstName = "Seshagiri";
p.LastName = "Sriram";
p.Introduce();