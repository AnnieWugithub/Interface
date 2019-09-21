using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo.DataClass
{
	public class Car:MotoMachine
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
