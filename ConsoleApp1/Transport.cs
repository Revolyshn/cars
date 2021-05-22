using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	class Transport
	{
		protected string name;
		protected string color;
		public Transport(string name,string color)
		{
			this.name = name;
			this.color = color;
		}

		public string getName()
		{
			return name;
		}

		public virtual void Move()
		{
			Console.WriteLine("перемещается");
		}

	}
}
