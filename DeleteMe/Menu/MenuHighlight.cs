using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChickenLauncherApp.Interfaces;

namespace ChickenLauncherApp.Menu
{
    public class MenuHighlight : IMenuHighlight
    {
        public void MenuHighlighter(string[] menuItems, ref int selectedIndex)
        {
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
        }
    }
}
