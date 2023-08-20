using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama
{
    public class custom
    {
        public static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Update();
            customerManager.Add();
            Console.ReadLine();
            Custo custo = new Custo();
            custo.Id = 1;
            custo.Name = "Test";
            custo.Description = "Test";
            Custo elmusto = new Custo { Id = 1, Name = "test", Description = "mawk" };
            Console.WriteLine(elmusto.Name);
            Console.ReadLine();

        }

        class CustomerManager
        {
            public void Add()
            {
                Console.WriteLine("Customer Add!");
            }
            public void Update()
            {
                Console.WriteLine("Customer Updated");
            }
        }


    }
}
