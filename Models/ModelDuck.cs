using System;
namespace StrategyPattern.Models
{
	public class ModelDuck : Duck
	{
		public ModelDuck()
		{
            qb = new MuteQuack();
            fb = new FlyNoWay();
		}

        public override void Display()
        {
            Console.WriteLine("Hey there, I'm a model duck!");
        }
    }
}

