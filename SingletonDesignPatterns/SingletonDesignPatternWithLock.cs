using System;

namespace SingletonDesignPatterns
{
    public sealed class SingletonDesignPatternWithLock
    {
        private SingletonDesignPatternWithLock()
        {
            Console.WriteLine("Hey i am from SingleTon with Lock Constructor \n");
        }

        private static readonly object PadLock = new object();
        private static SingletonDesignPatternWithLock _designPatternWithLock = null;

        public static SingletonDesignPatternWithLock GetSingletonDesignPatternWithLock
        {
            get
            {
                lock(PadLock) // here lock is applying every time, irrespective of instance null or not.
                {
                    Console.WriteLine("Instance Called \n");
                    if (_designPatternWithLock == null)
                    {
                        _designPatternWithLock = new SingletonDesignPatternWithLock();
                        Console.WriteLine("Instance Created \n");

                    }
                }

                return _designPatternWithLock;
            }
        }

        public void PrintSingleton()
        {
            Console.WriteLine("Hey i am from SingleTon with Lock \n");

        }
    }
}
