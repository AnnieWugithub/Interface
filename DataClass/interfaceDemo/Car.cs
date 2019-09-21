using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo.DataClass
{
	//只能繼承一個抽象類別，但可繼承很多介面
	public class Car:MotoMachine,ISpeedUp
	{
		public Car()
		{
			Name = "四人小客車";

		}
		public string Name { get; set; }
		public int Door { get; set; }
		public string CarGlass { get; set; }
		
	}
}
