using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo.DataClass
{
	public interface ISpeedUp //定義IFly介面 
	{
		void ISpeedUp(int n); //宣告Fly方法
	}


	public class MotoMachine
	{
		public MotoMachine()
		{
		}
		public string Tire { get; set; }
		public string Color { get; set; }

		public void Run()
		{
			Console.WriteLine("跑了5公里");
		}
		public void ISpeedUp(int n) {

			Console.WriteLine($"加速快跑{n}公里");
		

		}
	}
}
