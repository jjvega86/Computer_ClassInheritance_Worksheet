using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithClassesDay8
{
    class Games : Applications
    {
        public double requiredEffectiveMemory;

        public Games(double requiredEffectiveMemory)
        {
            this.requiredEffectiveMemory = requiredEffectiveMemory;
        }
    }
}
