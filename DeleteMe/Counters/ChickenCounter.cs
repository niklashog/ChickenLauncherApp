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
        private int _countChickens;
        public int Count()
        {
            return _countChickens += 1;
        }

        public int DisplayCount()
        {
            return _countChickens;
        }
    }
}
