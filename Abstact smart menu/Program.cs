using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smart_menu;

namespace Abstact_smart_menu
{
	class Program
	{
		static void Main(string[] args)
		{
			Menu menu = new Menu("Menu or\nwhatever");
			menu.AddMenuPoint(new SelectConfig());
			menu.Activate();
		}
	}
}
