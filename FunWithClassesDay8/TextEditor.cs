using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithClassesDay8
{
    class TextEditor : Applications
    {
        public TextEditor()
        {
            ApplicationName = "Slack";
            ApplicationType = "Messaging service";
            RequiredRAM = 4.0; //In Gigabytes
            RequiredStorage = 0.512; //In Gigabytes
        }
    }
}
