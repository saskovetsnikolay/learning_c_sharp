using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_types
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int b = Convert.ToInt32(a);
            float c = (float)b;
            long d = (long)b;
            decimal e = (decimal)b;
            double f = (double)b;

            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
        }
    }
}
