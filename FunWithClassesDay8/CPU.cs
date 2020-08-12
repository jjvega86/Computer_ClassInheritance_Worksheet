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
       
        public void ProcessGameInstall (Games game, HardDrive hardDrive, RAM ram)
        {
            hardDrive.ApplicationsInHardDrive.Add(game);

        }

        public bool CheckGameRequirements(Games game, HardDrive hardDrive, RAM ram, GPU graphics)
        {
            bool canRun = false;
            if (ram.totalGigabytes >= game.RequiredRAM && hardDrive.availableStorage >= game.RequiredStorage && game.requiredEffectiveMemory >= graphics.effectiveMemory)
            {
                hardDrive.ApplicationsInHardDrive.Add(game);
                canRun = true;
                
                
            }
            else
            {
                Console.WriteLine($"Your computer does not meet the minimum requirements for installing {game.ApplicationName}!");
            }

            return canRun;

        }
        public void ProcessTextEditorInstall(Games game, HardDrive hardDrive)
        {
            hardDrive.ApplicationsInHardDrive.Add(game);

        }

        public bool CheckTextEditorRequirements(TextEditor editor, HardDrive hardDrive, RAM ram)
        {
            bool canRun = false;
            if (ram.totalGigabytes >= editor.RequiredRAM && hardDrive.availableStorage >= editor.RequiredStorage)
            {
                hardDrive.ApplicationsInHardDrive.Add(editor);
                canRun = true;


            }
            else
            {
                Console.WriteLine($"Your computer does not meet the minimum requirements for installing {editor.ApplicationName}!");
            }

            return canRun;

        }
    }
}
