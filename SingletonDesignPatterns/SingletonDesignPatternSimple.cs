using System;

namespace SingletonDesignPatterns
{
    public sealed class SingletonDesignPatternSimple
    {
        private static int _counter = 1;
        private SingletonDesignPatternSimple()
        {
            Console.WriteLine("i am from constructor");
        }

        private static SingletonDesignPatternSimple _singletonDesignPattern = null;

        public static SingletonDesignPatternSimple GetSingletonDesignPattern
        {
            get
            {
                if (_singletonDesignPattern != null) return _singletonDesignPattern;
                _singletonDesignPattern = new SingletonDesignPatternSimple();
                Console.WriteLine($"Number instance created  :: {_counter} \n");
                _counter++;
                return _singletonDesignPattern;

            }
        }


        public void PrintSingleton()
        {
            Console.WriteLine("Hey i am from SingleTon \n");
            
        }
    }
}
