using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constractor
{
    public class YapıcıMethodInjection
    {
        static void Main(string[] args)
        {
            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            employeeManager.Add();

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();
        }

    class Product
        {
            public Product()
            {

            }

            private int _id;
            private string _name;
            public Product(int id,string name)
            {
                _id = id;
                _name = name;
            }
            public int Id { get; set; }
            public string Name { get; set; }
        }
        interface ILogger
        {
            void Log();
        }

        class DatabaseLogger : ILogger
        {
            public void Log()
            {
                Console.WriteLine("Database Logged");
            }
        }

        class FileLogger : ILogger
        {
            public void Log()
            {
                Console.WriteLine("File Logged");
            }
        }

        class EmployeeManager
        {
            private ILogger _logger;
            public EmployeeManager(ILogger logger)
            {
                _logger = logger;
            }

            public ILogger Logger { get; set; }
           public void Add()
            {
                _logger.Log();
                Console.WriteLine("Added");
            }     
        }

        class BaseClass
        {
            private string _entity;

            public BaseClass(String entity)
            {
                _entity = entity;
            }
            public void Message()
            {
                Console.WriteLine("{0}Message",_entity);
            }

        }

        class PersonManager : BaseClass
        {
            public PersonManager(string entity):base(entity)
            {
                
            }

            public void Add()
            {
                Console.WriteLine("Added");
                Message();
            }
        }


    }    
  }

