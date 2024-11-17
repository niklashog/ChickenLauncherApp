using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickenLauncherApp.Interfaces
{
    public interface IExecuteMenuOption
    {
        public void Execute(int index, ref bool running,
            IChickenLauncher chickenLauncher, IChickenCounter chickenCounter,
            ICustomLauncher customLauncher, ICustomCounter customCounter);
    }
}
