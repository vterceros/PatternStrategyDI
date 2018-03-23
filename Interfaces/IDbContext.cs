﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Interfaces
{
    public interface IDbContext : IDisposable
    {
        bool Save();
    }
}
