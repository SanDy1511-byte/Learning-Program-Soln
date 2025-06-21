using System;

class Program
{
    static void Main(string[] args)
    {
        Logger logger1 = Logger.Instance;
        logger1.Log("Application started.");

        Logger logger2 = Logger.Instance;
        logger2.Log("Another log message.");

        if (logger1 == logger2)
        {
            Console.WriteLine("Both logger instances are the same. Singleton works!");
        }
        else
        {
            Console.WriteLine("Logger instances are different. Singleton failed!");
        }
    }
}
