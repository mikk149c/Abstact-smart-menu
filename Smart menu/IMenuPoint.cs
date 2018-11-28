using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_menu
{
	public interface IMenuPoint
	{
		/// <summary>
		/// This is the name you will se in the menu
		/// </summary>
		/// <returns></returns>
		string GetMenuPointName();
		/// <summary>
		/// This is run when the menu point is selected
		/// You can run a new manu here if you want to create a submenu
		/// </summary>
		void Invoke();
	}
}
