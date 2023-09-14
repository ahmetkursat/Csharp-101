using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Event
{
    public class Class1
    {
        static void Main(string[] args)
        {
            Product hardisk = new Product(50);
            hardisk.ProductName = "Hard Disk";

            Product gsm = new Product(50);
            gsm.ProductName = "Gsm";

            for (int i = 0; i < 10; i++)
            {

                hardisk.Sell(10);
                gsm.Sell(10);

                
                gsm.StockControlEvent += Gsm_StockControlEvent;
                Console.ReadLine();

            }
            


            Console.ReadLine();
        }

        private static void Gsm_StockControlEvent()
        {
            Console.WriteLine("Gsm about to finish");
        }
    }
}
