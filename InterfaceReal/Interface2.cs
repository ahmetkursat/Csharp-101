using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceReal
{
    public class Interface2
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Worker()
            };

            foreach (var eat in eats)
            {
                eat.Eat();
            }

            ISalary[] salaries = new ISalary[2]
            {
               new Manager(),
               new Worker()
            };

            foreach (var salary in salaries)
            {
                salary.GetSalary();
            }
            Console.WriteLine();
        }

    interface IWorker
        {
            void Work();
        }
    interface IEat
        {
            void Eat();
        }
    interface ISalary
        {
            void GetSalary();
        }

        class Manager : IWorker, ISalary, IEat
        {
            public void Eat()
            {
                Console.WriteLine("Yemek Yendi");
            }

            public void GetSalary()
            {
                Console.WriteLine("10000");
            }

            public void Work()
            {
                Console.WriteLine("WORK");
            }
        }

        class Worker : IWorker, IEat, ISalary
        {
            public void Eat()
            {
                Console.WriteLine("Yemek Yedi");
            }

            public void GetSalary()
            {
                Console.WriteLine("10000");
            }

            public void Work()
            {
                Console.WriteLine("salam");
            }
        }
        class Robot : IWorker
        {
            public void Work()
            {
                Console.WriteLine("Çalıştı");
            }
        }


    }
}
