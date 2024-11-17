using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChickenLauncherApp.Interfaces;

namespace ChickenLauncherApp.Counters
{
    public class DisplayLaunchCounter : IDisplayLaunchCounter
    {
        private IChickenCounter _chickenCounter;
        private ICustomCounter _customCounter;
        public DisplayLaunchCounter(
            IChickenCounter chickenCounter,
            ICustomCounter customCounter)
        {
            _chickenCounter = chickenCounter;
            _customCounter = customCounter;
        }

        public void PrintCount()
        {
            Console.WriteLine(
            $"Chickens launched: {_chickenCounter.DisplayCount()}");

            Console.WriteLine(
            $"Custom objects launched: {_customCounter.DisplayCount()}");
        }
    }
}
