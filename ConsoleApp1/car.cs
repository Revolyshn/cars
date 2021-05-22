using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	class car : Transport
	{

		float volume;
		public float MaxSpeed;
		public car(string name, string color, float volume, float MaxSpeed) : base(name, color)
		{
			this.volume = volume;
			this.MaxSpeed = MaxSpeed;
		}
		public override void Move()
		{
			Console.WriteLine("еду");
		}

		public float getSpeed()
		{
			return MaxSpeed;
		}
	}
}
