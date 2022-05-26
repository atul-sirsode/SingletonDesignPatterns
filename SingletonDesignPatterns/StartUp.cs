using System;
using System.Threading.Tasks;

namespace SingletonDesignPatterns
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            Parallel.Invoke(CallingV1, CallingV2);

            Console.Read();
        }

        private static void CallingV2()
        {
            var singletonV2 = SingletonDesignPatternWithLazyLoad.Instance;
            singletonV2.PrintSingleton();
        }

        private static void CallingV1()
        {
            var singletonV1 = SingletonDesignPatternWithLazyLoad.Instance;
            singletonV1.PrintSingleton();
        }
    }
}

// With MultiThread simple singleton not worked if you changed reference of simplesingleton class in above calling methods
// you'll see that instance creation twice.
// that will change the behavior of singleton
