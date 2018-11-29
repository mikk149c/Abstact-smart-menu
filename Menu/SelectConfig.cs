using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smart_menu;
using Data;

namespace DataMenu
{
	class SelectConfig : IMenuPoint
	{
		private DataController dataController;
		public SelectConfig(DataController dataController)
		{
			this.dataController = dataController;
		}

		public string GetMenuPointName()
		{
			return "Select Config";
		}

		public void Invoke()
		{
			Menu menu = new Menu("Configurations\n\n");
			menu.ExitAfterInvoke = true;
			foreach (Configuration c in dataController.GetListOfConfig())
				menu.AddMenuPoint(new ConfigurationActionMenu(c, dataController));
			menu.Activate();
		}
	}
}