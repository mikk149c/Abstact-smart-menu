using System;
using System.Collections.Generic;

namespace Smart_menu
{
	public class Menu
	{
		string menuName;
		private List<IMenuPoint> menuPoints = new List<IMenuPoint>();
		int pointer = 0;
		private int outputLine { get { return menuName.Split('\n').Length + menuPoints.Count; } }

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
			while (!key.Equals(ConsoleKey.Escape));
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
			Console.Write("Press ESC to return");
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
			Console.SetCursorPosition(0, menuNameLineCount + menuPoints.Count + 1);
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

		private void clearCurrentLine()
		{
			int currentLineCursor = Console.CursorTop;
			Console.SetCursorPosition(0, Console.CursorTop);
			Console.Write(new string(' ', Console.WindowWidth));
			Console.SetCursorPosition(0, currentLineCursor);
		}

		private void clearLine(int i)
		{
			int currentLineCursor = Console.CursorTop;
			Console.SetCursorPosition(0, i);
			Console.Write(new string(' ', Console.WindowWidth));
			Console.SetCursorPosition(0, currentLineCursor);
		}

		private void clearOutput()
		{
			for (int i = outputLine; i < Console.WindowHeight-2; i++)
			{
				clearLine(i);
			}
		}
	}
}