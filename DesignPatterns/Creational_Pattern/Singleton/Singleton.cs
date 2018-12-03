using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Pattern.Singleton
{
    public class Singleton
    {
        private static Singleton _singleton;
        private Singleton()
        {

        }

        public static Singleton GetSingleton()
        {
            return _singleton ?? (_singleton = new Singleton());
        }

        /*To be able to use the singleton on different threads and ensure that there's no two threads will instantiates the singleton twice the design pattern is "Double-Checked Locking" 
         * It is typically used to reduce locking overhead when implementing "Lazy Initialization" in multithread enviroment, specially in singleton avoid initializing a value untill the first time it's accessed
        */
        private static object lockObject = new object();

        public static Singleton GetSafeThreadSingleton()
        {
            if (_singleton == null)
            {
                lock (lockObject) // lock
                {
                    if (_singleton == null) _singleton = new Singleton(); //check again after lock
                }
            }
            return _singleton;
        }

        //In .Net 4 there's a class Lazy<T> internally uses double-checked locking by default
        private static readonly Lazy<Singleton> _lazySingleton = new Lazy<Singleton>(() => new Singleton());

        public static Singleton GetSafeThreadLazySingleton()
        {
            return _lazySingleton.Value;
        }


        //Other useful methods here.
    }
}
