using System;
using Smart_menu;
using Data;

namespace DataMenu
{
	public class MainMenu
	{
		private DataController dataController;

		public MainMenu(DataController dataController)
		{
			this.dataController = dataController;
		}

		public void Activate()
		{
			Menu menu = new Menu("Main menu");
			menu.AddMenuPoint(new SelectConfig(dataController));
			menu.Activate();
		}
	}
}
