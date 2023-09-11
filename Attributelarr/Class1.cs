using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Attributelarr
{
    public class Class1
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer()
            {
                Id = 1,
                LastName = "yıldız",
                FirstName = "Ahemt",
                Age = 21
            };

            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);

            Console.ReadLine();

        }

        [ToTable("Customer")]
        class Customer
        {
            [Obsolete("Kardeşim bu koda kullanma")]
            public int Id  { get; set; }
            [RequiredProperty]
            public string FirstName { get; set; } 
            [RequiredProperty]
            public string LastName { get; set; }
            [RequiredProperty]
            public int Age  { get; set; }
            
        }


        class CustomerDal
        {
            public void Add(Customer customer)
            {
                Console.WriteLine("{0},{1},{2},{3} added",customer.FirstName,customer.LastName,customer.Age,customer.Id);
            }
        }
        [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field )]
        class RequiredPropertyAttribute:Attribute
        {
             
        }
        [AttributeUsage(AttributeTargets.Class)]
        class ToTableAttribute :Attribute
        {
            private string _tableName;

            public ToTableAttribute(string tableName)
            {
                _tableName = tableName;
            }
        }


    }
}
