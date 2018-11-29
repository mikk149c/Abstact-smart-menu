using System;
using System.Collections.Generic;
using System.Text;
using Smart_menu;
using Data;

namespace DataMenu
{
	class ConfigurationSchedual : IMenuPoint
	{
		DataController dataController;
		Configuration configuration;
		public ConfigurationSchedual(Configuration configuration, DataController dataController)
		{
			this.dataController = dataController;
		}

		public string GetMenuPointName()
		{
			return "Schedual";
		}

		public void Invoke()
		{
			Console.WriteLine("Schedualed");
		}
	}
}
