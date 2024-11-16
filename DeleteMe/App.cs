using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteMe
{
    public class App : IApp
    {
        private IChickenLauncher _launcher;
        private ICustomLauncher _customLauncher;

        public App(IChickenLauncher chickenLauncher, ICustomLauncher customLauncher)
        {
            _launcher = chickenLauncher;
            _customLauncher = customLauncher;
        }
        public void Run()
        {
            string[] menuItems = { "Launch chicken", "Load launcher yourself (CAUTION!)", "Back away from launcher.." };
            int selectedIndex = 0;
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("Chicken Launcher. Launching chickens since 1974.");

                // Render menyn
                for (int i = 0; i < menuItems.Length; i++)
                {
                    if (i == selectedIndex)
                    {
                        // Highlight the selected menu item
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"> {menuItems[i]}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine($"  {menuItems[i]}");
                    }
                }

                // Hantera tangenttryckningar
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
                        ExecuteMenuOption(selectedIndex, ref running);
                        break;
                }
            }

            void ExecuteMenuOption(int index, ref bool running)
            {
                switch (index)
                {
                    case 0: // Launch chicken
                        _launcher.Launch();
                        break;

                    case 1: // Launch custom object
                        _customLauncher.CustomLaunch();
                        break;

                    case 2: // Exit
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }
}
