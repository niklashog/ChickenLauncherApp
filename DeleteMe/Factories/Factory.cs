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
            builder.RegisterType<ChickenCounter>().As<IChickenCounter>().SingleInstance();
            builder.RegisterType<CustomLauncher>().As<ICustomLauncher>();
            builder.RegisterType<CustomCounter>().As<ICustomCounter>().SingleInstance();
            builder.RegisterType<DisplayLaunchCounter>().As<IDisplayLaunchCounter>();
            builder.RegisterType<DisplayLogo>().As<IDisplayLogo>();
            builder.RegisterType<ExecuteMenuOption>().As<IExecuteMenuOption>();
            builder.RegisterType<MenuNavigation>().As<IMenuNavigation>();
            builder.RegisterType<MenuHighlight>().As<IMenuHighlight>();

            _container = builder.Build();
        }

        public static T Resolve<T>()
        {
            return _container.Resolve<T>();
        }
    }
}