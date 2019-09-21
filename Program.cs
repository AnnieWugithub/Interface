using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceDemo.DataClass;

namespace InterfaceDemo
{
	public class Program
	{
		static void Main(string[] args)
		{
			Car car = new Car();
			Console.WriteLine(car.Name);
			car.Run();
			car.ISpeedUp(9);
			Console.Read();
		}
	}
}
