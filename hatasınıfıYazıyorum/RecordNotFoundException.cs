using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace hatasınıfıYazıyorum
{
    public class RecordNotFoundException:Exception
    {
        static void Main(string[] args)
        {

            try
            {
                Find();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }

            HandleExpection(() => { });
 
            Console.ReadLine();


        }

        private static void Find()
        {
            List<string> students = new List<string>() { "Ahmet", "Kürşad", "YILDIZ" };

            if (!students.Contains("Ahmett"))
            {
                throw new RecordNotFoundException("Record Not Found");
            }
            else
            {
                Console.WriteLine("Record Bulundu");
            }
        }

        public RecordNotFoundException(string message):base(message)
        {

        }
    }
}
