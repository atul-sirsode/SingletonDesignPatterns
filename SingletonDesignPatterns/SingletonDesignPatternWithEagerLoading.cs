using System;
using System.Diagnostics;

namespace SingletonDesignPatterns
{
    public sealed class SingletonDesignPatternWithEagerLoading
    {
        static SingletonDesignPatternWithEagerLoading()
        {
            Console.WriteLine($"Hey i am from Static SingleTon with Eager Constructor  \n");
        }

        private SingletonDesignPatternWithEagerLoading()
        {
           
        }
        private static readonly SingletonDesignPatternWithEagerLoading _isntance =
            new SingletonDesignPatternWithEagerLoading();

        public static SingletonDesignPatternWithEagerLoading Instance
        {
            get
            {
                Console.WriteLine($"Instance Called  {new StackTrace().GetFrame(1)?.GetMethod()?.Name} \n");
                return _isntance;
            }
        }

        public void PrintSingleton()
        {

            Console.WriteLine($"Hey i am from PrintSingleton::SingleTon with Eager Loading from \n");

        }
    }
}
