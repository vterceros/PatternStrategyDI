using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Production");
            //we do not need to inject a dbcontext here because by default it uses the real one
            RealUse real = new RealUse();
            real.ManipulateData();
            Console.WriteLine("Unit Testing");
            UnitTest tdd = new UnitTest();
            tdd.TestDataManupulation();
            Console.ReadKey();

        }
    }
}
