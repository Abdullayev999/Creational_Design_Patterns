using System.Collections.Generic;

namespace Singleton_Pattern
{
    class Singleton
    {
        static private Singleton instance;

        static public Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                } 

                return instance;
            }
        }

        public List<int> Data { get; set; }

        private Singleton()
        {
            Data = new List<int>();
        }

    }
}