using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Reflection
{
    public class Class1
    {
        static void Main(string[] args)
        {
            //DörtIslem islem = new DörtIslem(2,3);
           
            
            //Console.WriteLine(islem.Topla(3, 4));
            //Console.WriteLine(islem.Topla2());

            var type = typeof(DörtIslem);

            var instance = Activator.CreateInstance(type, 5, 6);

            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");

            methodInfo.Invoke(instance, null);

            //DörtIslem dortIslem =  (DörtIslem)Activator.CreateInstance(type,6,7);
            //Console.WriteLine(dortIslem.Topla(4, 5));
            
            //Console.WriteLine(dortIslem.Topla2());

            var metodlar = type.GetMethods();

            foreach (var info in metodlar)
            {
                Console.WriteLine("Metod Adı : {0}",info.Name);
                foreach (var para in info.GetParameters())
                {
                    Console.WriteLine("Parametre : {0} ",para.Name);
                    
                }

                foreach (var attribut in info.GetCustomAttributes())
                {
                    Console.WriteLine(attribut.GetType().Name);
                    
                }

            }
            
            Console.ReadLine();
        }
    }

    public class DörtIslem
    {
        private int _sayi1, _sayi2;

        public DörtIslem(int sayi1,int sayi2)
        {
            
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }

        public DörtIslem()
        {
            
        }


        public int Topla(int sayi1, int sayi2)
        {
            return sayi1+sayi2;
        }public int Carp(int sayi1, int sayi2)
        {
            return sayi1*sayi2;
        }
        public int Topla2()
        {
            return _sayi1 +_sayi2;
        }
        [MetodName("Carpma")]
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }

        public class MetodNameAttribute:Attribute
        {
            public MetodNameAttribute(string name)
            {
                
            }
        }


    }
}
