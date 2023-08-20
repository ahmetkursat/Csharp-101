using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritance
{
    public class ornek
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            Person[] persons = new Person[3]
            {
                new Customer{FirstName="AHMET",LastName="Kürşad"},
                new Student{FirstName="Ahmet"},
                new Person{ FirstName="Nur"}
            };

            Console.WriteLine();

            foreach (Person person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();


        } 
    class Person
        {
            public int Id { get; set; }

            public string FirstName { get; set; }

            public string LastName { get; set; }
        }

    class Customer : Person
        {
            public string City { get; set; }
        }

    class Student : Person
        {
            public string Deparment { get; set; }

        }


    }
}
