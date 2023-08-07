
// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Strategy_Pattern.Services;
using StrategyPattern;
using StrategyPattern.Models;

Console.WriteLine("Hello, World!");


IHost _host = Host.CreateDefaultBuilder()
                 .ConfigureServices(services =>
                 {
                     services.AddSingleton<IApplication, Application>();
                     services.AddTransient<Duck, ModelDuck>();
                     services.AddTransient<Duck, RocketPoweredDuck>();
                     services.AddTransient<FlyBehavior, FlyWithWings>();
                     services.AddTransient<FlyBehavior, FlyNoWay>();
                     services.AddTransient<QuackBehavior, Quack>();
                     services.AddTransient<QuackBehavior, Squeak>();
                     services.AddTransient<QuackBehavior, MuteQuack>();
                 })
                 .Build();

var app = _host.Services.GetRequiredService<IApplication>();
app.Run();