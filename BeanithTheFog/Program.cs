using System;

public class Program
{
    public static void Main() {

        string[] menuItems = { "New Game", "Load Game", "Exit" };
        int selectIndex = 0;

        int top = (Console.WindowHeight - menuItems.Length) / 2;
        while (true) {
        PrintCentered("--=Beanith The Fog=--\n\n");

            Console.SetCursorPosition(0, top);
            for (int i = 0; i < menuItems.Length; i++) {
                // colored buttons
                if (i == selectIndex) {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else {
                    Console.ResetColor();
                }
                // output
                PrintCentered(menuItems[i]);
                Console.ResetColor();
            }

            // choose buttons
            ConsoleKey button = Console.ReadKey(true).Key;
            if (button == ConsoleKey.DownArrow) {
                selectIndex++;
            }
            else if (button == ConsoleKey.UpArrow) {
                selectIndex--;
            }

            if (selectIndex < 0) {
                selectIndex = 0;
            }
            else if (selectIndex >= menuItems.Length) {
                selectIndex = menuItems.Length - 1;
            }

            Console.SetCursorPosition(0, 0);
        }
        Console.ReadKey();
        // center text
        static void PrintCentered(string text) {
            int left = (Console.WindowWidth - text.Length) / 2;
            Console.SetCursorPosition(left, Console.CursorTop);
            Console.WriteLine(text);
        }
    }
}