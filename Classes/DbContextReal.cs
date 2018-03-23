using DependencyInjection.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Classes
{
    class DbContextReal : IDbContext
    {        
        public bool Save()
        {
            //Real code here
            Console.WriteLine("Data saved in the DB");
            return true;
        }
        public void Dispose()
        {}
    }
}
