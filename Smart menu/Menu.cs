using System;
using System.Collections.Generic;

namespace Smart_menu
{
	public class Menu
	{
		string menuName;
		private List<IMenuPoint> menuPoints = new List<IMenuPoint>();
		private int pointer = 0;
		private int outputLine { get { return menuName.Split('\n').Length + menuPoints.Count + 1; } }
		public bool ExitAfterInvoke { get; set; } = false;

		public Menu(string menuName)
		{
			this.menuName = menuName + '\n';
		}

		public void AddMenuPoint (IMenuPoint point)
		{
			menuPoints.Add(point);
		}

		public void Activate()
		{
			Console.Clear();
			displayMenu();
			if (!menuPoints.Count.Equals(0))
			{
				ConsoleKey key;
				do
				{
					key = Console.ReadKey(true).Key;
					switch (key)
					{
						case ConsoleKey.UpArrow:
							movePointerUp();
							break;
						case ConsoleKey.DownArrow:
							movePointerDown();
							break;
						case ConsoleKey.Enter:
							clearOutput();
							menuPoints[pointer].Invoke();
							displayMenu();
							break;
					}
				}
				while (!key.Equals(ConsoleKey.Escape) && !(key.Equals(ConsoleKey.Enter) && ExitAfterInvoke));
			}
			else
			{
				Console.WriteLine("There are no menu points");
				Console.ReadKey();
			}
			Console.Clear();
		}

		private void displayMenu()
		{
			Console.SetCursorPosition(0, 0);
			Console.CursorVisible = false;
			Console.WriteLine(menuName);
			displayMenuPoints();
			displayInstructions();
			Console.SetCursorPosition(0, outputLine);
		}

		private static void displayInstructions()
		{
			Console.SetCursorPosition(0, Console.WindowHeight-1);
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Black;
			Console.Write("Press ESC to return");
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.White;
		}

		private void displayMenuPoints()
		{
			for (int i = 0; i < menuPoints.Count; i++)
				displayMenuPoint(i);
		}

		private void displayMenuPoint(int i)
		{
			if (i.Equals(pointer))
			{
				Console.BackgroundColor = ConsoleColor.DarkGray;
				Console.WriteLine(menuPoints[i].GetMenuPointName());
				Console.BackgroundColor = ConsoleColor.Black;
			}
			else
			{
				Console.WriteLine(menuPoints[i].GetMenuPointName());
			}
		}

		private void updateMenuPoint(int i)
		{
			int menuNameLineCount = menuName.Split('\n').Length;
			Console.SetCursorPosition(0, menuNameLineCount + i);
			displayMenuPoint(i);
			Console.SetCursorPosition(0, outputLine);
		}

		private void movePointerDown()
		{
			movePointer(1);
		}

		private void movePointerUp()
		{
			movePointer(-1);
		}

		private void movePointer(int v)
		{
			int point1ToUpdate = pointer;
			pointer += v;
			if (pointer < 0)
				pointer = 0;
			if (pointer > menuPoints.Count - 1)
				pointer = menuPoints.Count - 1;
			int point2ToUpdate = pointer;
			if (!point1ToUpdate.Equals(point2ToUpdate))
			{
				updateMenuPoint(point1ToUpdate);
				updateMenuPoint(point2ToUpdate);
			}
		}

		private void clearOutput()
		{
			for (int i = outputLine; i < Console.WindowHeight-2; i++)
			{
				MenuUtility.ClearLine(i);
			}
		}
	}
}