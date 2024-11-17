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
    public class App : IApp
    {
        private IDisplayLaunchCounter _launchCounter;
        private IDisplayLogo _displayLogo;
        private IExecuteMenuOption _executeMenuOption;
        private IMenuNavigation _menuNavigation;
        private IMenuHighlight _menuHighlight;

        public App(

            IDisplayLaunchCounter launchCounter,
            IDisplayLogo displayLogo,
            IExecuteMenuOption execute,
            IMenuNavigation menuNavigation,
            IMenuHighlight menuHighlight)
        {

            _launchCounter = launchCounter;
            _displayLogo = displayLogo;
            _executeMenuOption = execute;
            _menuNavigation = menuNavigation;
            _menuHighlight = menuHighlight;
        }
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
                Console.WriteLine(_displayLogo.Print());

                _menuHighlight.MenuHighlighter(menuItems, ref selectedIndex);
                _launchCounter.PrintCount();
                _menuNavigation.MenuNavigator(menuItems, ref running, ref selectedIndex);
            }
        }
    }
}
