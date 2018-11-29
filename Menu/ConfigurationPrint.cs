using System;
using System.Collections.Generic;
using System.Text;
using Smart_menu;
using Data;

namespace DataMenu
{
	class ConfigurationPrint : IMenuPoint
	{
		DataController dataController;
		Configuration configuration;
		public ConfigurationPrint(Configuration configuration, DataController dataController)
		{
			this.dataController = dataController;
		}

		public string GetMenuPointName()
		{
			return "Print";
		}

		public void Invoke()
		{
			Console.WriteLine("Printed");
		}
	}
}
