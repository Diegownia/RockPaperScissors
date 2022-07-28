﻿using System;
using Autofac;
using Games.Data.Core;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = GetContainer();
            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IMainMenu>();
                app.Welcome();
            }
            Console.ReadLine();
        }

        static IContainer GetContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MainMenu>().As<IMainMenu>();
            builder.RegisterType<Game1>().As<IGame1>();
            builder.RegisterType<Drawer>().As<IDrawer>();
            builder.RegisterType<ScoreCalculator>().As<IScoreCalculator>();
            builder.RegisterType<RockPaperScissorsModel>().As<IRockPaperScissorsModel>().SingleInstance();
            builder.RegisterType<DataService>().As<IDataService>();
            builder.RegisterType<RockPaperScissorsDeepLogic>().As<IRockPaperScissorsDeepLogic>().SingleInstance();

            return builder.Build();
        }
    }
}
