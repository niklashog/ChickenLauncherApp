using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChickenLauncherApp.Interfaces;

namespace ChickenLauncherApp.Counters
{
    public class ChickenCounter : IChickenCounter
    {
        private int _chickenCounter;
        public void Count()
        {
            _chickenCounter += 1;
        }

        public int DisplayCount()
        {
            return _chickenCounter;
        }
    }
}