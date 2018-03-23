using DependencyInjection.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Classes
{
    class DbContextFake : IDbContext
    {
        public bool Save()
        {
            //Fake code here or nothing
            Console.WriteLine("Nothing was saved it is a fake context");
            return true;
        }
        public void Dispose()
        {
        }        
    }
}
