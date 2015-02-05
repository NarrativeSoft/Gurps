using System;

namespace Gurps
{
	public class Damage
	{
		public Damage (int thrust, int swing)
		{
			this.Thrust = thrust;
			this.Swing = swing;
		}

		public int Thrust {get;set;}
		public int Swing {get;set;}
	}
}

