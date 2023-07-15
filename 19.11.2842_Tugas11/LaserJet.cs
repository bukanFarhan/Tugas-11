using System;
using System.Collections.Generic;
using System.Text;

namespace _19._11._2842_Tugas11
{
	public class LaserJet : PrinterWindows
	{
		public override void Show()
		{
			Console.WriteLine("\nLaserJet display dimension: 12*12");
		}

		public override void Print()
		{
			Console.WriteLine("LaserJet printer printing....");
		}
	}
}
