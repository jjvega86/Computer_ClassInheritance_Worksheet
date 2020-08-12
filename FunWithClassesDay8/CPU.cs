using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithClassesDay8
{
    class CPU
    {
        public string manufacturer;
        public string name;

        public CPU(string manufacturer, string name)
        {
            this.manufacturer = manufacturer;
            this.name = name;
        }
       
        public void ProcessInstall (Applications app, HardDrive hardDrive, RAM ram)
        {
            hardDrive.ApplicationsInHardDrive.Add(app);

        }

        public bool CheckRequirements(Applications app, HardDrive hardDrive, RAM ram, GPU graphics)
        {
            bool canRun = false;
            if (ram.totalGigabytes >= app.RequiredRAM && hardDrive.availableStorage >= app.RequiredStorage)
            {
                hardDrive.ApplicationsInHardDrive.Add(app);
                canRun = true;
                
            }
            else
            {
                Console.WriteLine($"Your computer does not meet the minimum requirements for installing {app.ApplicationName}!");
            }

            return canRun;

        }
    }
}
