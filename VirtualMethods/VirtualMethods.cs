using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    public class VirtualMethods
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();   
            Mysql mysql = new Mysql();

            sqlServer.Add();
            mysql.Add();

            Console.ReadLine();

        }


    
    class DataBase
        {
            public virtual void Add() //eğerki add methodu aynı ama kullanacagımız classta farklı ise methodu override ederiz methodu ezmek için
                                      //virtual method olması lazım böyle bir durumda inhertinca den yardım alırz interface de olmaz
            { 
                Console.WriteLine("Added By Defult");
            }

            public virtual void Delete()
            {
                Console.WriteLine("Deleted By Default");
            }

        }

        class SqlServer : DataBase
        {
            public override void Add()
            {
                Console.WriteLine("Add by sql kod");
                //base.Add();
            }
        }

        class Mysql :DataBase
        {

        }
        



    }
}
