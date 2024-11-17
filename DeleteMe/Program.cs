using ChickenLauncherApp.Factories;
using ChickenLauncherApp.Interfaces;

namespace ChickenLauncherApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factory.BuildContainer();
            var app = Factory.Resolve<IApp>();
            app.Run();
        }
    }
}
