using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructClass
{
    public class AbstructClass
    {
        static void Main(string[] args)
        {
            Database database = new OracleServer();
            database.Delete();
            database.add();
            Database database1 = new SqlServer();
            database1.Delete();
            database1.add();
        }

    abstract class Database
        {
            public void add()
            {
                Console.WriteLine("Added by default");
            }

            public abstract void Delete();


        }
        class SqlServer : Database
        {
            public override void Delete()
            {
                Console.WriteLine("Deleted By SqlServer");
            }
        }

        class OracleServer : Database
        {
            public override void Delete()
            {
                Console.WriteLine("Deleted By Oracle");
            }
        }

    }
}
