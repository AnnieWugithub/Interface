using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceDemo.DataClass;
using abstractDemo.DataClass;
using delegateDemo.DataClass;
using FuncDemo.DataClass;
namespace InterfaceDemo
{
	public class Program
	{

		static void Main(string[] args)
		{
			//interfaceDemo();
			//abstractDemo();
			//delegateDemo();
			funcDemo();
			Console.Read();
		}
		/// <summary>
		/// 介面
		/// </summary>
		static void interfaceDemo()
		{
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
		static void delegateDemo()
		{
			Custom custom = new Custom(SendAction.SendFromMon);
			Console.Write($"媽媽{custom(10).ToString()}");
		}

		static void funcDemo()
		{
			//Init一個Person物件
			Person p = new Person()
			{
				Age = 10,
				Name = "tom"
			};
			#region Func
			//宣告一個Func<Person,string>委託 _thunkCheckAge
			Func<Person, string> _thunkCheckAge;
			//_thunkCheckAge委託指向CheckAge方法
			_thunkCheckAge = new Func<Person, string>(CheckAge);
			//執行_thunkCheckAge委託 (執行CheckAge方法)
			string result = _thunkCheckAge(p);
			//最後將結果顯示出來
			Console.WriteLine(result);
			#endregion
			Console.ReadKey();
		}
		public static string CheckAge(Person person)
		{
			string result = "年紀剛剛好";
			if (person.Age >= 10)
			{
				result = "老人";
			}
			return result;
		}

	}
}
