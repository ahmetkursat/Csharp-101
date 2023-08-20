using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama.InterFace
{
    class Program {
    static void Main(string[] args)
    {
            /*  interface giriş  PersonManager manager = new PersonManager();
            Customer customer = new Customer
            { 
                ID = 2,
                FirstName = "Malak",
                LastName = "2213",
                Adress = "null"
            };
            Student student = new Student
            {
                ID = 1,
                FirstName = "cenj",
                LastName = "murat"
            };
            manager.Add(new Student { LastName = " student", FirstName = "student", ID = 5 }); 
            manager.Add(new Customer { ID = 1, FirstName = "Ahmet", LastName = "Kursad",Adress ="Perkam"});
            manager.Add(customer);
            Console.WriteLine(manager);  soyut nesnelerin ana methodlarının interface veya abscrat sınıfı oluşturulmaz*/



            Console.ReadLine();
        }
    }


    interface IPerson
    {
        int ID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }

    class Customer:IPerson
    {
        public int ID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Adress { get; set; }
    }
    class Student :IPerson
    {
        public int ID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.ID +person.LastName);
        }
    }

}
