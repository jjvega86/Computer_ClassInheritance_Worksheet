using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FunWithClassesDay8
{
    class Motherboard
    {
        public string manufacturer;
        public CPU processor;
        public RAM temporaryMemory;
        public HardDrive storage;
        public GPU graphics;

        public Motherboard(string manufacturer, CPU processor, RAM temporaryMemory, HardDrive storage, GPU graphics)
        {
            this.manufacturer = manufacturer;
            this.processor = processor;
            this.temporaryMemory = temporaryMemory;
            this.storage = storage;
            this.graphics = graphics;

        }

       
    }
}
