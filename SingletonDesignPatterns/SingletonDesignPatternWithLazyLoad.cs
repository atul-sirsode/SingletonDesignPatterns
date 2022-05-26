using System;

namespace SingletonDesignPatterns
{
    public sealed class SingletonDesignPatternWithLazyLoad
    {
        private SingletonDesignPatternWithLazyLoad()
        {
            Console.WriteLine("i am from lazy constructor");
        }

        private static readonly Lazy<SingletonDesignPatternWithLazyLoad> Lazy =
            new Lazy<SingletonDesignPatternWithLazyLoad>((() => new SingletonDesignPatternWithLazyLoad()));

        public static SingletonDesignPatternWithLazyLoad Instance => Lazy.Value;

        public void PrintSingleton()
        {

            Console.WriteLine($"Hey i am from PrintSingleton::SingleTon with Lazy Loading from \n");

        }
    }
}
