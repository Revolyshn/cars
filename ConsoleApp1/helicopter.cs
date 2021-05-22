using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	class helicopter : Transport
	{
		float weight;
		public helicopter(string name,string color,float weight):base(name,color)
		{
			this.weight = weight;
		}
		public override void Move()
		{
			Console.WriteLine("Лечу");
		}
	}
}
