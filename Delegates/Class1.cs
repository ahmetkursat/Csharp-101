using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace Delegates
{
    public delegate void MyDelegate();
    public delegate void MyDelegate2(string text);
    public delegate int MyDelegate3(int number1,int number2);

    public class Class1
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            

            customerManager.SendMessage();
            customerManager.ShowAlert();


            MyDelegate dDelegate = customerManager.SendMessage;
            dDelegate += customerManager.ShowAlert;
            dDelegate();

            dDelegate-=customerManager.SendMessage;


            MyDelegate2 dMyDelegate = customerManager.SendMessage2;
            dMyDelegate+= customerManager.ShowAlert2;
            dMyDelegate("Selam");

            Matematik matematik = new Matematik();

            matematik.Topla(2,3);
            MyDelegate3 myDelegate3 = matematik.Topla;
            myDelegate3 += matematik.Carp;
            var sonuc = myDelegate3(2, 3);
            

           Console.WriteLine(sonuc);

            Console.ReadKey();
        }
    }

    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello");
        }

        public void ShowAlert()
        {
            Console.WriteLine("Be careful");
        }

        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }

        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }

        
    }
    public class Matematik
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

    }
}
