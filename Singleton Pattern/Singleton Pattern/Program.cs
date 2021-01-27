using System;
using System.Collections.Specialized;

namespace Singleton_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton.Instance.Data.Add(1);

            Singleton obj1 = Singleton.Instance;
            Singleton obj2 = Singleton.Instance;
            Singleton obj3 = Singleton.Instance;

            obj1.Data.Add(2); 
            obj2.Data.Add(3);
            obj3.Data.Add(4);

            foreach (var item in Singleton.Instance.Data)
            {
                Console.WriteLine(item);
            }
        }
    }
}
