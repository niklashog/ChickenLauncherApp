using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickenLauncherApp.Interfaces
{
    public interface IMenuNavigation
    {
        public void MenuNavigator(string[] menuItems, ref bool running, ref int selectedIndex);
    }
}
