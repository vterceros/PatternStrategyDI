using DependencyInjection.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class UnitTest
    {
        public void TestDataManupulation()
        {
            //here we call the fake db context following the Unit Test rules
            Console.WriteLine("Dependency injection now");
            RealUse realFake = new RealUse(new DbContextFake());
            if (realFake.ManipulateData())
            {
                //assert true
            }            
        }
    }
}
