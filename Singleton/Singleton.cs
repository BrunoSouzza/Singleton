using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        private static readonly Lazy<Singleton> _lazySingleton = new Lazy<Singleton>((() => new Singleton()));
        
        private Singleton()
        {

        }


        public static Singleton Instance
        {
            get { return _lazySingleton.Value; }
        }
    }
}
