using System;
namespace StrategyPattern.Models
{
	public class FlyWithWings : FlyBehavior
	{
		public FlyWithWings()
		{
		}

        public void Fly()
        {
            Console.WriteLine("I'm flying with wings!");
        }
    }
}

