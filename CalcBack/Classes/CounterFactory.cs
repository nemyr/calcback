using CalcBack.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalcBack.Classes
{
    public class CounterFactory : ICounterFactory
    {
        public const string typeAdd = "add";
        public const string typeSub = "sub";

        public ICounter GetCounter(string type)
        {
            switch (type)
            {
                case typeAdd : 
                    return new Addition();
                case typeSub:
                    return new Substraction();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
