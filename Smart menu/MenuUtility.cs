using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_menu
{
	public static class MenuUtility
	{
		public static void SearchMenu(List<string> zipCodes, out string output)
		{
			output = "";
			ConsoleKeyInfo key;
			do
			{
				int inputLine = Console.CursorTop;
				Console.WriteLine(output);
				foreach (string s in zipCodes)
					if (s.StartsWith(output))
						Console.WriteLine(s);
				key = Console.ReadKey();
				if (key.Key.Equals(ConsoleKey.Backspace))
				{
					if (output.Length > 0)
						output = output.Substring(0, output.Length - 1);
				}
				else if (!key.Key.Equals(ConsoleKey.Enter))
					output += key.KeyChar;
				for (int i = inputLine; i < Console.WindowHeight; i++)
					ClearLine(i);
				Console.SetCursorPosition(0, inputLine);
			} while (!key.Key.Equals(ConsoleKey.Enter));
		}

		public static void ClearCurrentLine()
		{
			int currentLineCursor = Console.CursorTop;
			Console.SetCursorPosition(0, Console.CursorTop);
			Console.Write(new string(' ', Console.WindowWidth));
			Console.SetCursorPosition(0, currentLineCursor);
		}

		public static void ClearLine(int i)
		{
			int currentLineCursor = Console.CursorTop;
			Console.SetCursorPosition(0, i);
			Console.Write(new string(' ', Console.WindowWidth));
			Console.SetCursorPosition(0, currentLineCursor);
		}
	}
}
