using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateDemo.DataClass
{
	public delegate int Custom(int amount);
	public class SendAction
	{
		public static int SendFromFather(int amount)
		{
			amount *= 2;
			return amount;
		}
		public static int SendFromSister(int amount)
		{
			amount *= 3;
			return amount;
		}

		public static int SendFromMon(int amount)
		{
			amount *= 4;
			return amount;
		}
	}
}
