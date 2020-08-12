using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithClassesDay8
{
    class HardDrive
    {
        public double totalStorage;
        public double availableStorage;
        public List<Applications> ApplicationsInHardDrive;

        public HardDrive(double totalStorage, double availableStorage)
        {
            this.totalStorage = totalStorage;
            this.availableStorage = availableStorage;
            ApplicationsInHardDrive = new List<Applications>();
        }
    }
}
