using System;

public class Program
{
	public static void Main() {

        PrintCentered("--=Beanith The Fog=--\n\n");


		string[] menuItems = { "New Game", "Load Game", "Exit" };
		int selectIndex = 0;

		for (int i = 0; i < menuItems.Length; i++) {
				PrintCentered(menuItems[i]);
		}

        Console.ReadKey();
    }

	// center text
	static void PrintCentered(string text) {
		int left = (Console.WindowWidth - text.Length) / 2;
		Console.SetCursorPosition(left, Console.CursorTop);
        Console.WriteLine(text);
	}
}