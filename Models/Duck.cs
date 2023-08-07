using System;
using StrategyPattern.Models;

namespace StrategyPattern
{
	public abstract class Duck
	{
		protected FlyBehavior fb;
		protected QuackBehavior qb;
		public Duck()
		{
		}

		public abstract void Display();

		public void SetFlyBeahvior(FlyBehavior fb)
		{
			this.fb = fb;
        }

        public void SetQuackBeahvior(QuackBehavior qb)
        {
            this.qb = qb;
        }

        public void PerformQuack()
		{
			qb.Quack();
		}

		public void PerformFly()
		{
			fb.Fly();
		}
	}
}

