using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smart_menu;

namespace Abstact_smart_menu
{
	class SelectConfig : IMenuPoint
	{
		List<Configuration> configurations = new List<Configuration>
			{
			new Configuration("CFG1"),
			new Configuration("CFG2"),
			new Configuration("CFG3"),
			new Configuration("CFG4"),
			new Configuration("Bober")
			};
		public string GetMenuPointName()
		{
			return "Select Config";
		}

		public void Invoke()
		{
			Menu menu = new Menu("Configurations\n\n");
			foreach (IMenuPoint m in configurations)
				menu.AddMenuPoint(m);
			menu.Activate();
		}
	}
}
