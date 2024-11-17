using ChickenLauncherApp.Factories;
using ChickenLauncherApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickenLauncherApp.Menu
{
    public class ExecuteMenuOption : IExecuteMenuOption
    {
        private readonly IChickenLauncher _chickenLauncher;
        private readonly IChickenCounter _chickenCounter;
        private readonly ICustomLauncher _customLauncher;
        private readonly ICustomCounter _customCounter;
        public ExecuteMenuOption(
            IChickenLauncher chickenLauncher, IChickenCounter chickenCounter,
            ICustomLauncher customLauncher, ICustomCounter customCounter)
        {
            
        }
        public void Execute(int index, ref bool running, 
            IChickenLauncher chickenLauncher, IChickenCounter chickenCounter,
            ICustomLauncher customLauncher, ICustomCounter customCounter)
        {

            switch (index)
            {
                case 0:
                    chickenLauncher.Launch();
                    chickenCounter.Count();
                    break;

                case 1:
                    customLauncher.Launch();
                    customCounter.Count();
                    break;

                case 2:
                    running = false;
                    break;

                default:
                    Console.WriteLine("Felaktigt val.");
                    break;
            }
        }
    }
}
