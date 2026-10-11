using System;

public class Story {
    static int health = 80;
    static int stamina = 60;
    static string[] inventory = new string[5];
    public static void Start() {

        Console.Clear();
        string[] captions = {
            "\n\n\n\n\n\nIt’s an oppressive morning; a crow is cawing outside the window, and rays of sunlight are barely filtering through the thick fog, illuminating your house.",
            "\n\n\n\n\n\nThe air is cold.",
            ""
        };

        int currentCaption = 0;
        int selectedAction = 0;

        while (true) {
            Console.Clear();

            ShowPlayerStatus();


            Console.WriteLine(captions[currentCaption]);
            Console.WriteLine();

            Console.WriteLine(selectedAction == 0 ? "> Continue" : "  Continue");
            Console.WriteLine(selectedAction == 1 ? "> Back" : "  Back");

            ConsoleKey key = Console.ReadKey(true).Key;
            // check
            if (key == ConsoleKey.UpArrow || key == ConsoleKey.DownArrow) {
                selectedAction = 1 - selectedAction;
            }
            else if (key == ConsoleKey.Enter) {
                if (selectedAction == 0 && currentCaption < captions.Length - 1) {
                    currentCaption++;
                }
                else if (selectedAction == 1 && currentCaption > 0) {
                    currentCaption--;
                }
            }
            else if (key == ConsoleKey.Escape) {
                break;
            }
        }


        Console.ReadKey(true);
    }
    static void ShowPlayerStatus() {
        Console.SetCursorPosition(0, 0);
        Console.WriteLine($"HP: {health}/100");
        Console.WriteLine($"Stamina: {stamina}/100");

        Console.SetCursorPosition(100, 0);
        Console.WriteLine($"Inventory: ");

        for (int i = 0; i < inventory.Length; i++) {
            string item = inventory[i] ?? "Empty";

            Console.SetCursorPosition(100, i + 1);
            Console.WriteLine($"{i + 1}. {item}");
        }
    }

    static bool PickUpItem(string item) {
        for (int i = 0; i < item.Length; i++) {
            if (inventory[i] == null) {
                inventory[i] = item;
                return true;
            }
        }
        return false;
    }
}
