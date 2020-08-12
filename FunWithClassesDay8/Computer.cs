using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithClassesDay8
{
    class Computer
    {
        public Motherboard motherboard;
        


        public Computer()
        {
            CPU processor = new CPU("Intel", "i3");
            RAM tempMemory = new RAM(2.0, "MemEx");
            HardDrive storage = new HardDrive(250.0, 250.0);
            GPU graphics = new GPU("BlazeGraphics", 2.0);
            motherboard = new Motherboard("Dell", processor, tempMemory, storage, graphics);
        }

        public void BuildComputer()
        {
            //I want to prompt the user to build the computer using this method
        }
      
    }
}
