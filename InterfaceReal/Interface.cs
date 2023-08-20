//using System;
//using System.Collections.Concurrent;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace InterfaceReal
//{

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            CustomerManager manager = new CustomerManager();
//            manager.Add(new SqlServerCustomerDal());
//            manager.Add(new OracleCustomerDal());
//            Console.ReadLine();
//        }
//        interface ICustomer
//        {
//            void Add();
//            void Update();
//            void Delete();

//        }
//        class SqlServerCustomerDal : ICustomer
//        {
//            public void Add()
//            {
//                Console.WriteLine("Sql Server Add");
//            }

//            public void Delete()
//            {
//                Console.WriteLine("Sql server delete");
//            }

//            public void Update()
//            {
//                Console.WriteLine("Sql update");
//            }
//        }
//        class OracleCustomerDal : ICustomer
//        {
//            public void Add()
//            {
//                Console.WriteLine("Oracle Added");
//            }

//            public void Delete()
//            {
//                Console.WriteLine("Oracle Deleted");
//            }

//            public void Update()
//            {
//                Console.WriteLine("Oracle Update");
//            }
//        }

//         class CustomerManager
//            {
//            public void Add(ICustomer customerDal)
//            {
//                customerDal.Add();
//            }
//        }

//        }
//   }

