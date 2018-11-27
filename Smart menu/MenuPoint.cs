using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_menu
{
	public interface IMenuPoint
	{
		string GetMenuPointName();
		void Invoke();
	}
}
