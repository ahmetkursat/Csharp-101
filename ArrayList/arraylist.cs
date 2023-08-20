using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListeleri
{
    public class arraylist
    {
        static void Main(string[] args)
        {

           ArrayList cities = new ArrayList();

            cities.Add("Ankara");
            cities.Add("Adana");

            foreach (var i in cities)
            {
                Console.WriteLine(i);
            }

            cities.Add("İstanbul");
            Console.Write(cities[2]);

            Console.ReadLine();
            //çalışılan nesnede veri tipi yoksa diziler sadece tek değişkenle çalışır diziyle aynı 

        }
    }
}
