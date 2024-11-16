using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickenLauncherApp
{
    public class CustomLauncher : ICustomLauncher
    {
        public void CustomLaunch()
        {
            Console.Clear();
            Console.WriteLine("What do you want to put into the launcher?");
            Console.Write("Making the careful choice: ");
            string answer = Console.ReadLine();
            Console.WriteLine($"Boom! Launches {answer} at the speed of light! Flaying all the way to.. Kramfors? What the?!");
            Console.WriteLine("Custom sound here!! Probably high pitched.. never to be heard again..");
            Console.ReadKey();
        }
    }
}
