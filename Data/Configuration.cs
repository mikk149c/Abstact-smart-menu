using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
	public class Configuration
	{
		private string name;
		public string Name { get { return name; } set { name = value; } }

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
