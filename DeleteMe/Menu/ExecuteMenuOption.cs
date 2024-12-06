using ChickenLauncherApp.Counters;
using ChickenLauncherApp.Factories;
using ChickenLauncherApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickenLauncherApp.Menu
{
    public class ExecuteMenuOption(
        IChickenLauncher chickenLauncher,
        ICustomLauncher customLauncher,
        IChickenCounter chickenCounter,
        ICustomCounter customCounter) : IExecuteMenuOption
    {
        public void Execute(int index, ref bool running)
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
