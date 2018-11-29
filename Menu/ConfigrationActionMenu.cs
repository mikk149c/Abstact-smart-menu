using System;
using System.Collections.Generic;
using System.Text;
using Smart_menu;
using Data;

namespace DataMenu
{
	class ConfigurationActionMenu : IMenuPoint
	{
		DataController dataController;
		Configuration configuration;

		public ConfigurationActionMenu(Configuration configuration, DataController dataController)
		{
			this.dataController = dataController;
			this.configuration = configuration;
		}

		public string GetMenuPointName()
		{
			return configuration.Name;
		}

		public void Invoke()
		{
			Menu menu = new Menu("Action");
			menu.ExitAfterInvoke = true;
			menu.AddMenuPoint(new ConfigurationPrint(configuration, dataController));
			menu.AddMenuPoint(new ConfigurationSchedual(configuration, dataController));
			menu.AddMenuPoint(new ConfigurationDelete(configuration, dataController));
			menu.Activate();
		}
	}
}
