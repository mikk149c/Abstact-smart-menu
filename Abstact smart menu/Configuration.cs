using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smart_menu;

namespace Abstact_smart_menu
{
	class Configuration : IMenuPoint
	{
		private string name;

		public Configuration(string name)
		{
			this.name = name;
		}

		public string GetMenuPointName()
		{
			return name;
		}

		public void Invoke()
		{
			Console.WriteLine($"My name is {name}\nAnd what else {name.Length}");
			//Console.ReadKey();
		}
	}
}
