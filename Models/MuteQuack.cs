using System;
namespace StrategyPattern.Models
{
	public class MuteQuack : QuackBehavior
	{
		public MuteQuack()
		{
		}

        public void Quack()
        {
            Console.WriteLine("<<Silence>>");
        }
    }
}

