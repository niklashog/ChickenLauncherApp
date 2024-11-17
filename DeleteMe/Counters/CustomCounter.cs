using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChickenLauncherApp.Interfaces;

namespace ChickenLauncherApp.Counters
{
    public class CustomCounter : ICustomCounter
    {
        private int _countCustompicks;
        public int Count()
        {
            return _countCustompicks += 1;
        }

        public int DisplayCount()
        {
            return _countCustompicks;
        }
    }
}
