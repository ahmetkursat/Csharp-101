using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Listeler
{
    public class Listeler
    {
        static void Main(string[] args)
        {
            //List<string> cities = new List<string>();
            //   cities.Add("Ankara");
            //   cities.Add(1);
            //   //listeler özelleştirlmiş dizilerdir sadece verilen değerlerin üzerine veri üretebiliriz
            //   Console.ReadLine();

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, FirstName = "Ajöet" });
            customers.Add(new Customer { Id = 2, FirstName = "asdsad" });

            //foreach (var city in cities)
            //{
            //    Console.WriteLine(city);
            //}
        }
         class Customer
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
        }
    }
    }
  

