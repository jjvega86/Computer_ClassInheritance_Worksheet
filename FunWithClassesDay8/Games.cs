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

        public Games()
        {
            requiredEffectiveMemory = 2.0;
            ApplicationName = "Slack";
            ApplicationType = "Messaging service";
            RequiredRAM = 4.0; //In Gigabytes
            RequiredStorage = 0.512; //In Gigabytes
        }
    }
}
