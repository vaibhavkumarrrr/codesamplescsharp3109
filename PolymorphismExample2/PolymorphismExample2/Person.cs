using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample2
{
    internal class Person
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
