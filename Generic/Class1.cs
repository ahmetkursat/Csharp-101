using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Class1
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara", "İzmir", "Adana");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            List<Customer> result2 = utilities.BuildList<Customer>(new Customer
            {
                FirstName = "Ahmet",
                LastName = "YILDIZ"
               
            },new Customer {
                FirstName = "Ahmet",
                LastName = "YILDIZ"
            });
            foreach (var customer in result2)
            {
                Console.WriteLine(customer.FirstName);
                Console.WriteLine(customer.LastName);
            }


            Console.ReadLine();


        }
    }
    class Utilities
    {
        public List<T> BuildList<T>( params T[] items)
        {
            return new List<T>(items);
        }
    }

    class Product
    {
        

    }
    interface IProductDal:IRepositorty<Product>
    {
    

    }

    public class Customer{
        public string FirstName { get; set; }

        public string LastName { get; set; }

    }

    interface ICustomerDal:IRepositorty<Customer>
    {

    }
    

    interface IRepositorty<T>  where T:class ,new() //burada kısıtları belirliyoruz 
    {
        List<T> GetAll();
        T Get(int id);

        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);

    }

    class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }

    class CustomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
