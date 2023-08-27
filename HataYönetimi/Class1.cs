using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HataYönetimi
{
    public class Class1
    {
        static void Main(string[] args)
        {
            try
            {
                string[] students = new string[3] { "Ahmet", "Kürşad", "YILDIZ" };

                students[3] = "hasan";
             }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
            
            Console.ReadLine();

        }
    }
}
