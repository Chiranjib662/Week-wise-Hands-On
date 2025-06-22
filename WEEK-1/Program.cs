using System;

namespace SingletonPatternExample   // ✅ Must match Logger.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.GetInstance();
            Logger logger2 = Logger.GetInstance();

            logger1.Log("Logging first message.");
            logger2.Log("Logging second message.");

            if (object.ReferenceEquals(logger1, logger2))
            {
                Console.WriteLine("logger1 and logger2 refer to the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton pattern not working correctly.");
            }
        }
    }
}
