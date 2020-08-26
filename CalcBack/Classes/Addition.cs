using CalcBack.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalcBack.Classes
{
    public class Addition : ICounter
    {
        public float Count(float param1, float param2)
        {
            return param1 + param2;
        }
    }
}
