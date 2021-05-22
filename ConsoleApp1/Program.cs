using System;
using System.Text;

namespace ConsoleApp1
{
	class Program
	{
		public static Transport tranc = new car("car1", "", 20.7f, 1.5f);
		public static Transport tranc2 = new car("car2", "", 20.7f, 1.5f);
		public static Transport tranh = new helicopter("", "", 50009);
		public static StringBuilder sb = new StringBuilder("___________________________________________________");
		public static StringBuilder sb2 = new StringBuilder("___________________________________________________");
		private static System.Timers.Timer timer;
		private static float[] i = { 0, 0 };
		private static Random rand = new Random();
		private static Transport winner;
		private static Transport[] cars = new Transport[1];
		static void Main(string[] args)
		{
			tranc.Move();
			tranh.Move();
			timer = new System.Timers.Timer(100);
			timer.Elapsed += new System.Timers.ElapsedEventHandler(tickHandler);
			timer.Enabled = true;
			while (winner is null)
			{
				if(winner != null)
				{
					Console.WriteLine();
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine("Выйграл " + winner.getName());
					Console.ResetColor();

				}
			}
			if(winner != null)
			{
				Console.WriteLine();
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Выйграл " + winner.getName() + " " + i[1] + " " + i[0]);
				Console.ResetColor();
			}
			Console.ReadKey();
		}

		private static void tickHandler(object source, System.Timers.ElapsedEventArgs e)
		{
			if(i[0] < sb.Length && i[1] < sb.Length)
			{
				Console.Clear();
				i[0] += 0.1f * ((car)tranc).getSpeed() + (float)rand.NextDouble();
				if(i[0] < sb.Length)
				{
					sb.Replace("→", "_");
					sb.Insert((int)i[0], "→");
					sb.Remove((int)i[0] + 1, 1);
				}
				Console.Write(sb);
				Console.WriteLine();
				i[1] += 0.1f * ((car)tranc2).getSpeed() + (float)rand.NextDouble();
				if (i[1] < sb2.Length)
				{
					sb2.Replace("→", "_");
					sb2.Insert((int)i[1], "→");
					sb2.Remove((int)i[1] + 1, 1);
				}
	
				Console.Write(sb2);
			}
			else
			{
				if(i[0] >= sb.Length - 1)
				{
					winner = tranc;
				}
				else
				{
					winner = tranc2;
				}
			}

			
		}
	}
}
