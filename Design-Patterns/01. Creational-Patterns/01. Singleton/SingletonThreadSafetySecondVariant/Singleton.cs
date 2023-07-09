using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonThreadSafetySecondVariant
{
    public class Singleton
    {
        private static readonly Singleton instance = new Singleton();

        public string Date { get; private set; }

        private Singleton()
        {
            Date = DateTime.Now.TimeOfDay.ToString();
        }

        public static Singleton GetInstance()
        {
            return instance;
        }
    }
}
