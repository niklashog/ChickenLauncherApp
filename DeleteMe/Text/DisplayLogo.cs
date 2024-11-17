using ChickenLauncherApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickenLauncherApp.Text
{
    public class DisplayLogo : IDisplayLogo
    {
        public string Print()
        {
            return "Chicken Launcher. Launching chickens since 1974.";
        }
    }
}
