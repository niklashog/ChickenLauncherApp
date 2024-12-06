using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChickenLauncherApp.Counters;
using ChickenLauncherApp.Interfaces;
using ChickenLauncherApp.Launchers;
using ChickenLauncherApp.Menu;
using ChickenLauncherApp.Factories;

namespace ChickenLauncherApp
{
    public class App(
        IDisplayLaunchCounter launchCounter,
        IDisplayLogo displayLogo,
        IExecuteMenuOption execute,
        IMenuNavigation menuNavigation,
        IMenuHighlight menuHighlight) : IApp
    {
        public void Run()
        {
            string[] menuItems = {
                "Launch chicken", 
                "Load launcher yourself (CAUTION!)", 
                "Back away from launcher.." };
            int selectedIndex = 0;
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine(displayLogo.Print());

                menuHighlight.MenuHighlighter(menuItems, ref selectedIndex);
                launchCounter.PrintCount();
                menuNavigation.MenuNavigator(menuItems, ref running, ref selectedIndex);
            }
        }
    }
}
