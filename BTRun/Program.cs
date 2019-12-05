using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// comment

namespace BTRun
{
    class Program
    {
        static void Main(string[] args)
        {
            GetValues gv = new GetValues();
            Console.WriteLine(gv.GetThree());
            Console.ReadKey();

        }
    }
}
