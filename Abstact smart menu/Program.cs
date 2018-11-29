using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataMenu;
using Data;

namespace Abstact_smart_menu
{
	class Program
	{
		static void Main(string[] args)
		{
			DataController dataController = new DataController();
			MainMenu menu = new MainMenu(dataController);
			menu.Activate();
		}
	}
}
