using System;
namespace StrategyPattern.Models
{
	public class FlyNoWay : FlyBehavior
	{
		public FlyNoWay()
		{
		}

        public void Fly()
        {
            Console.WriteLine("I can't fly.");
        }
    }
}

