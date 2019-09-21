using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractDemo.DataClass
{
	/// <summary>
	/// 抽象類別 抽象方法可覆寫orerrride 
	/// </summary>
	public abstract class Human
	{
		private string name;
		private DateTime birthday;

		public string Name { get; set; }
		public DateTime Birthday { get; set; }

		public void Sleep() { Console.WriteLine("zZＺ"); }
		public abstract void SayHello();
	}

	/// <summary>
	/// 一般方法 繼承抽像類別
	/// </summary>
	public class Taiwanese : Human
	{
		public override void SayHello()
		{
			Console.WriteLine("你好");
		}
	}

	public class Japanese : Human
	{
		public override void SayHello()
		{
			Console.WriteLine("こんにちは");
		}
	}

	public class American : Human
	{
		public override void SayHello()
		{
			Console.WriteLine("Hello");
		}
	}
}
