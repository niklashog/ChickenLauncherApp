using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChickenLauncherApp.Interfaces;

namespace ChickenLauncherApp.Counters
{
    public class DisplayTimesLaunched : IDisplayTimesLaunched
    {

        public void PrintCounter(IChickenCounter chickenCounter, ICustomCounter customCounter)
        {
            Console.SetCursorPosition(0, 5);
            Console.WriteLine($"Chickens launched: {chickenCounter.DisplayCount()}");
            Console.SetCursorPosition(0, 1);

            Console.SetCursorPosition(0, 6);
            Console.WriteLine($"Custom launches made: {customCounter.DisplayCount()}");
            Console.SetCursorPosition(0, 1);
            Console.CursorVisible = false;
        }
    }
}
