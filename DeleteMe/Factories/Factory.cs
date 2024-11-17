using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using ChickenLauncherApp.Counters;
using ChickenLauncherApp.Interfaces;
using ChickenLauncherApp.Launchers;
using ChickenLauncherApp.Menu;
using ChickenLauncherApp.Text;

namespace ChickenLauncherApp.Factories
{
    public class Factory
    {
        public static IContainer _container;

        public static void BuildContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<App>().As<IApp>();
            builder.RegisterType<ChickenLauncher>().As<IChickenLauncher>();
            builder.RegisterType<ChickenCounter>().As<IChickenCounter>();
            builder.RegisterType<CustomLauncher>().As<ICustomLauncher>();
            builder.RegisterType<CustomCounter>().As<ICustomCounter>();
            builder.RegisterType<DisplayTimesLaunched>().As<IDisplayTimesLaunched>();
            builder.RegisterType<DisplayLogo>().As<IDisplayLogo>();
            builder.RegisterType<ExecuteMenuOption>().As<IExecuteMenuOption>();

            _container = builder.Build();
        }

        public static T Resolve<T>()
        {
            return _container.Resolve<T>();
        }
    }
}