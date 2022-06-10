using System;

namespace Singleton
{
    public class Singleton
    {
        private static readonly Lazy<Singleton> _lazySingleton = new Lazy<Singleton>((() => new Singleton()));
        
        private static int count = 0;

        private Singleton()
        {
            count++;
            Console.WriteLine($"Instance:{count}");
        }

        public static Singleton Instance
        {
            get { return _lazySingleton.Value; }
        }
    }
}
