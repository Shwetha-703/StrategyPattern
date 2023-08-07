using System;
namespace StrategyPattern.Models
{
	public class Quack : QuackBehavior
	{
		public Quack()
		{
		}

        void QuackBehavior.Quack()
        {
            Console.WriteLine("Quack Quack");
        }
    }
}

