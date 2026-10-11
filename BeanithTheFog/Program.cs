using System;
using static Story;

public class Program
{
    public static void Main() {
        

        string[] menuItems = { "New Game", "Load Game", "Tutorial", "Lore", "Exit" };
        int selectIndex = 0;

        
        while (true) {
            Console.Clear();
            int top = (Console.WindowHeight - menuItems.Length) / 2;
            PrintCentered("--=Beanith The Fog=--");
            Console.WriteLine();
            Console.WriteLine();

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

            // Button New Game
            if (button == ConsoleKey.Enter) {
                if (selectIndex == 0) {
                    Start();
                }
            }

            // Button tutorial
            if (button == ConsoleKey.Enter) {
                if (selectIndex == 2) {
                    Tutorial();
                }            
            }

            // Button Lore
            if (button == ConsoleKey.Enter) {
                if (selectIndex == 3) {
                    Lore();
                }
            }

            //Button exit
            if (button == ConsoleKey.Enter) {
                if (selectIndex == 4) {
                    return;
                }
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

        static void Tutorial() {
            Console.Clear();

            PrintCentered("=========================================== Tutorial ===========================================");
            Console.WriteLine();
            Console.WriteLine("Beanith The Fog is a text-based RPG played entirely in your console.");
            Console.WriteLine("All events, battles, and actions will be described in text, so you'll need to use your imagination.");
            Console.WriteLine("Press BACKSPACE to return to the main menu.");
            PrintCentered("=== Combat ===");
            Console.WriteLine("The combat system is based on actions. During combat, you have several actions available:");
            Console.WriteLine("1. Quick Attack");
            Console.WriteLine("2. Heavy Attack");
            Console.WriteLine("3. Defend");
            Console.WriteLine("4. Use Item");
            Console.WriteLine("5. Use special skill\n");
            PrintCentered("=== Inventory ===");
            Console.WriteLine("1. At the start of the game, you have 5 inventory slots available, but as you play, you can increase the number of inventory slots");
            Console.WriteLine("2. If your inventory is full, you won't be able to pick up an item.");
            Console.WriteLine("   In that case, you can drop an item from your inventory, but it will be lost forever.\n");
            PrintCentered("=== Merchants ===");
            Console.WriteLine("1. You can buy weapons, potions, spells, or valuable information from merchants.");
            Console.WriteLine("2. You earn money by exploring the world, opening chests and hiding places, and defeating enemies.\n");
            PrintCentered("=== Exploration ===");
            Console.WriteLine();

            while (true) {
                ConsoleKey button = Console.ReadKey(true).Key;

                if (button == ConsoleKey.Backspace) {
                    Console.Clear();
                    return;
                }
            }
        }

        static void Lore() {
            Console.Clear();

            PrintCentered("=========================================== Lore ===========================================");
            Console.WriteLine();
            Console.WriteLine("Press BACKSPACE to return to the main menu.\n");
            PrintCentered("===The Structure of the World ===");
            Console.WriteLine("The story of Beanith The Fog takes place in the Middle Ages.");
            Console.WriteLine("A mysterious, thick fog has descended upon the Kingdom of Vaeloria. Panic has gripped Greyhaven, the kingdom’s capital.");
            Console.WriteLine("The Kingdom of Vaeloria is a poor kingdom in the south. Its inhabitants are mainly engaged in farming or fishing.");
            Console.WriteLine("Lately, almost no one has been venturing out to sea; most ships mysteriously disappear and never return.");
            Console.WriteLine("Vaeloria is not yet starving, but food has become much scarcer. Along with the fog came the plague. ");
            


            while (true) {
                ConsoleKey button = Console.ReadKey(true).Key;

                if (button == ConsoleKey.Backspace) {
                    Console.Clear();
                    return;
                }
            }
        }
    }
}