using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = args[2];
            //Console.WriteLine("siemanko " + name);
            foreach (var item in args)
            {
                Console.WriteLine("siemanko" + item);
            }
        }
    }
}
