// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
new Dog().Speak();
new Animal().Speak();
Animal bruno = new Dog(); 
bruno.Speak(); // "The dog barks."

Animal great = new Cat(); 
great.Speak(); // "The cat meows."

bruno   = great;
bruno.Speak(); // "The cat meows."