using DependencyInjection.Classes;
using DependencyInjection.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class RealUse
    {
        private IDbContext db;
        public RealUse()
        {
            this.db = new DbContextReal();
        }
        public RealUse(IDbContext db)
        {
            this.db = db;
        }

        public bool ManipulateData()
        {
            //Code here
            return this.db.Save();
        }
    }
}
