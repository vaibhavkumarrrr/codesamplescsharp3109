﻿namespace csharp.training.congruent.classes
{
    public class Person
    {

        private string _firstName; 
        private string _lastName;
        private string _middleName;

        public Person()
        {
            _firstName = "John";
            _lastName = "Doe";
            _middleName = "";
        }

        public override string ToString()
        {
            return "test...." + FullName;
        }
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }    

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string MiddleName
        {
            get { return _middleName; }
            set { _middleName = value; }
        }

        public string FullName { 
                get { 
                return $"{FirstName} {MiddleName} {LastName}".Trim(); 
            }
        }
        public virtual void Introduce()
        {
            Console.WriteLine($"Hello, my name is {FullName}.");
        }
    }
}
