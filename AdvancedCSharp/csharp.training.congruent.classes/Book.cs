namespace csharp.training.congruent.classes
{
    using System;
    using System.Net.Http.Headers;
    using System.Reflection.Metadata.Ecma335;
    using System.Runtime.CompilerServices;
    using System.Text;

    public class Book
    {
        private string _name = "Unknown";
        private string _description = "Unknown";
        private string _author = "Unknown";
        private string _isbn = "Unknown";

        public override string ToString()
        {
            return $"Name {Name}, Author: {Author}, ISBN: {Isbn},Descripton: {Description}"; 
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Description
        {
            get { return _description;  }
            set { _description = value; }
        }
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }
        public string Isbn
        {
            get { return _isbn; }
            set { _isbn = value; }
        }
        public Book()
        {
            Name = "Unknown"; 
            Author = "Unknown";
            Description = "Unknown";
            Isbn = "Unknown";
        }
        public Book(string name, string author, string description, string isbn)
        {
            Name = name; Author = author; Description = description; Isbn = isbn;
        }

        public bool GetWordInDescription(string word)
        {
            return _description.Contains(word, StringComparison.CurrentCulture);
        }

        public void DescribeBook()
        {
            BookPrinter.PrintBook(this); 
        }

        public bool IsBookWrittenBy(string author)
        {
            return Author == author; // this is wrong..
        }
        // Note that there is no print method.... 
        // No Save Method... 
    }
}

