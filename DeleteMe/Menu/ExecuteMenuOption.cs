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
    public class ExecuteMenuOption : IExecuteMenuOption
    {
        private IChickenLauncher _chickenLauncher;
        private ICustomLauncher _customLauncher;
        private IChickenCounter _chickenCounter;
        private ICustomCounter _customCounter;

        public ExecuteMenuOption(
            IChickenLauncher chickenLauncher,
            ICustomLauncher customLauncher,
            IChickenCounter chickenCounter,
            ICustomCounter customCounter)
        {
            _chickenLauncher = chickenLauncher;
            _customLauncher = customLauncher;
            _chickenCounter = chickenCounter;
            _customCounter = customCounter;
        }
        public void Execute(int index, ref bool running)
        {

            switch (index)
            {
                case 0:
                    _chickenLauncher.Launch();
                    _chickenCounter.Count();
                    break;

                case 1:
                    _customLauncher.Launch();
                    _customCounter.Count();
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
