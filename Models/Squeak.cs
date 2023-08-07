using System;
namespace StrategyPattern.Models
{
	public class Squeak : QuackBehavior
	{
		public Squeak()
		{
		}

        public void Quack()
        {
			Console.WriteLine("Squeak Squeak");
        }
    }
}

