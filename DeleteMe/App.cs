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
        private IChickenLauncher _chickenLauncher;
        private ICustomLauncher _customLauncher;
        private IChickenCounter _chickenCounter;
        private ICustomCounter _customCounter;
        private IDisplayTimesLaunched _displayTimesLaunched;
        private IDisplayLogo _displayLogo;
        private IExecuteMenuOption _executeMenuOption;

        public App(
            IChickenLauncher chickenLauncher, 
            ICustomLauncher customLauncher,
            IChickenCounter chickenCounter,
            ICustomCounter customCounter,
            IDisplayTimesLaunched displayTimesLaunched,
            IDisplayLogo displayLogo,
            IExecuteMenuOption execute)
        {
            _chickenLauncher = chickenLauncher;
            _customLauncher = customLauncher;
            _chickenCounter = chickenCounter;
            _customCounter = customCounter;
            _displayTimesLaunched = displayTimesLaunched;
            _displayLogo = displayLogo;
            _executeMenuOption = execute;
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

                //Menu Highlight
                for (int i = 0; i < menuItems.Length; i++)
                {
                    if (i == selectedIndex)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine($"> {menuItems[i]}");
                        Console.ResetColor();
                    }

                    else
                    {
                        Console.WriteLine($"  {menuItems[i]}");
                    }
                }

                _displayTimesLaunched.PrintCounter(_chickenCounter, _customCounter);


                //Menu Navigation

                var key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        selectedIndex = (selectedIndex == 0) ? menuItems.Length - 1 : selectedIndex - 1;
                        break;

                    case ConsoleKey.DownArrow:
                        selectedIndex = (selectedIndex == menuItems.Length - 1) ? 0 : selectedIndex + 1;
                        break;
                    case ConsoleKey.Enter:
                        _executeMenuOption.Execute(
                            selectedIndex, 
                            ref running, 
                            _chickenLauncher,
                            _chickenCounter,
                            _customLauncher,
                            _customCounter);
                        break;
                }
            }
        }
    }
}
