using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singlton
{
    class Singlton
    {
        static Singlton uniqInstance;
        protected Singlton()
        {
        }

        public static Singlton Instance()
        {
            if (uniqInstance==null)
            {
                uniqInstance = new Singlton();
            }
            return uniqInstance;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Singlton singlton1 = Singlton.Instance();
            Singlton singlton2 = Singlton.Instance();
            if (ReferenceEquals(singlton1,singlton2))
            {
                Console.WriteLine("объект Одиночка работает");
            }
            else
            {
                Console.WriteLine("объект Одиночка не работает");
            }
        }
    }
}
