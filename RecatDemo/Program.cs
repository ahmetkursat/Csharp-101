namespace RecatDemo
{
    class Program
    {
        static void Main(string[] args)
        {
        CustomerManager manager = new CustomerManager();
            manager.Add();
            manager.Logger = new DatabaseLogger();
            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        public ILogger Logger { get; set; }
        public void Add()
        {
            //Logger logger = new Logger();
            //logger.Log(); 
            //DatabaseLogger logger = new DatabaseLogger(); bu hataları yapma
            Logger.Log();
            Console.WriteLine("Customer Added");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("selam");
        }
    }

    class DatabaseLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged!");
        }
    }
    interface ILogger
    {
        void Log();
    }


}