using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_StructureSample
{
    struct Person {
       public  string firstName;
       public string lastName;
      public  int age;
        //public string FirstName { get => firstName; set => firstName = value; }
        //public string LastName { get => lastName; set => lastName = value; }
        //public int Age { get => age; set => age = value; }
        public Person(string _firstname,string _lastName,int _age)
        {
            firstName = _firstname;
            lastName = _lastName;
            age = _age;

        }
        public override string ToString()
        {
            return firstName + " " + lastName + " " + age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person adem = new Person("Adem", "AKKUŞ", 39);
            Console.WriteLine(adem.ToString());
            Person gulten = new Person();
           
            Console.WriteLine(gulten.ToString());
            
            Console.ReadKey();
        }
    }
}
