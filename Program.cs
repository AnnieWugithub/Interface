using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceDemo.DataClass;
using abstractDemo.DataClass;
using delegateDemo.DataClass;
namespace InterfaceDemo
{
	public class Program
	{
		
		static void Main(string[] args)
		{
			//interfaceDemo();
			//abstractDemo();
			delegateDemo();
			Console.Read();
		}
		/// <summary>
		/// 介面
		/// </summary>
		static void interfaceDemo() {
			Car car = new Car();
			Console.WriteLine(car.Name);
			car.Run();
			car.ISpeedUp(9);
		}
		/// <summary>
		/// 抽象類別、抽象方法
		/// </summary>
		static void abstractDemo()
		{
			Taiwanese taiwan = new Taiwanese();
			taiwan.Name = "臺灣人";
			taiwan.SayHello();
		}
		static void delegateDemo() {
			Custom custom = new Custom(SendAction.SendFromMon);
			Console.Write($"媽媽{custom(10).ToString()}");
		}
		
	}
}
