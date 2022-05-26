using System;
using System.Diagnostics;

namespace SingletonDesignPatterns
{
    public sealed class SingletonDesignPatternWithDoubleLocking
    {
       
        private SingletonDesignPatternWithDoubleLocking()
        {
           
            Console.WriteLine($"Hey i am from SingleTon with Double Lock Constructor  \n");
        }

        private static readonly object PadLock = new object();
        private static SingletonDesignPatternWithDoubleLocking _instance;

        public static SingletonDesignPatternWithDoubleLocking Instance
        {
            get
            {
                if (_instance != null) return _instance;

                lock (PadLock)
                {
                    Console.WriteLine($"Instance Called  {new StackTrace().GetFrame(1)?.GetMethod()?.Name} \n");
                    if (_instance != null) return _instance;
                    _instance = new SingletonDesignPatternWithDoubleLocking();
                    Console.WriteLine($"Instance Created  \n");
                }
                return _instance;
            }
        }
        public void PrintSingleton()
        {

            Console.WriteLine($"Hey i am from SingleTon with Double Lock from \n");

        }
    }
}
