using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalcBack.Interfaces
{
    public interface ICounterFactory
    {
        ICounter GetCounter(string type);
    }
}
