using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SingletonPattern.SingletonInstance
{
    public class Singleton
    {
        private static Singleton _instance;
        private static readonly object _lock = new object();
        public string myOutcome { get; set; } = "I am a singleton instance.";

        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                    return _instance;
                }
            }
        }

        public string ExecuteMethod()
        {
            return myOutcome;
        }
    }
}
