using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat2
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertIntToString someMethod = new ConvertIntToString(HiThere);
            string messege = someMethod(5);
            Console.WriteLine(messege);
            Console.ReadKey();
        }
        delegate string ConvertIntToString(int i);
        private static string HiThere(int i)
        {
            return "Witamy towarzyszu " + (i * 100);
        }
    }
  
}
