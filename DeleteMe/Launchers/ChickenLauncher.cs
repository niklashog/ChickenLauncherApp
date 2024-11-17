using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChickenLauncherApp.Interfaces;

namespace ChickenLauncherApp.Launchers
{
    public class ChickenLauncher : IChickenLauncher
    {
        public void Launch()
        {
            Console.Clear();
            Console.WriteLine(
                "Boom!! Launches a chicken at the speed of light!");
            Console.WriteLine(
                "Ka-Ka-Kakkaaaaaaaaaaaa!!!");
            Console.WriteLine(
                "That chicken was one of a kind. You would've made good friends..");
            Console.ReadKey();
        }
    }
}
