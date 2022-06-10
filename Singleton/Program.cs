using System;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Program
    {
        //Testing Implementation
        static void Main(string[] args)
        {

            Singleton singleton1 = Singleton.Instance;
            Singleton singleton2 = Singleton.Instance;

            if (singleton1 == singleton2)
                Console.WriteLine("Equals");
            else
                Console.WriteLine("Differents");

        }

        //Testing in a multi-threaded
        //static void Main(string[] args)
        //{
        //    Parallel.Invoke(
        //        () => Thread1(),
        //        () => Thread2()
        //    );

        //}

        //private static void Thread1()
        //{
        //    Singleton singleton1 = Singleton.Instance;
        //    Console.WriteLine("Thread 1");
        //}
        //private static void Thread2()
        //{
        //    Singleton singleton2 = Singleton.Instance;
        //    Console.WriteLine("Thread 2");
        //}
    }
}
