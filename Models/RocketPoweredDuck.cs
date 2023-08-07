using System;
namespace StrategyPattern.Models
{
	public class RocketPoweredDuck : Duck
	{
		public RocketPoweredDuck()
		{
            qb = new Squeak();
            fb = new FlyNoWay();
		}

        public override void Display()
        {
            Console.WriteLine("Hi there, I'm a rocket powered duck!");
        }
    }
}

