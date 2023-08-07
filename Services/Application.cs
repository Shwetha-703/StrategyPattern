using System;
using StrategyPattern;
using StrategyPattern.Models;

namespace Strategy_Pattern.Services
{

    public interface IApplication
    {
        void Run();   
    }

    public class Application : IApplication
	{
		public Application()
		{
		}

        public void Run()
        {
            Console.WriteLine("Hello from application class");

            Duck model = new ModelDuck();
            model.Display();
            model.PerformFly();
            model.PerformQuack();

            Duck rocket = new RocketPoweredDuck();
            rocket.Display();
            rocket.PerformFly();
            rocket.PerformQuack();
            Console.WriteLine("But now...");

            rocket.SetFlyBeahvior(new FlyWithWings());
            rocket.SetQuackBeahvior(new Quack());

            rocket.PerformFly();
            rocket.PerformQuack();

        }
    }
}

