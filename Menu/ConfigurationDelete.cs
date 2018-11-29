using System;
using System.Collections.Generic;
using System.Text;
using Smart_menu;
using Data;

namespace DataMenu
{
	class ConfigurationDelete : IMenuPoint
	{
		DataController dataController;
		Configuration configuration;
		public ConfigurationDelete(Configuration configuration, DataController dataController)
		{
			this.dataController = dataController;
			this.configuration = configuration;
		}

		public string GetMenuPointName()
		{
			return "Delete";
		}

		public void Invoke()
		{
			dataController.Delete(configuration.Name);
			Console.WriteLine("Deleted");
		}
	}
}
