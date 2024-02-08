namespace Exercise3;

public class Program
{
    private static int[] inventory = new int[5];
    private static string[] items = new string[] { "Item1", "Item2", "Item3", "Item4", "Item5" };

    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Spaghetti Inventory System!");

        int choice;
        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add item");
            Console.WriteLine("2. Remove item");
            Console.WriteLine("3. Check stock");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Select item to add:");
                    for (int i = 0; i < items.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {items[i]}");
                    }
                    int addItemIndex = int.Parse(Console.ReadLine()) - 1;
                    Console.Write("Enter quantity to add: ");
                    int quantityToAdd = int.Parse(Console.ReadLine());
                    inventory[addItemIndex] += quantityToAdd;
                    Console.WriteLine($"Added {quantityToAdd} {items[addItemIndex]} to inventory.");
                    break;
                case 2:
                    Console.WriteLine("Select item to remove:");
                    for (int i = 0; i < items.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {items[i]}");
                    }
                    int removeItemIndex = int.Parse(Console.ReadLine()) - 1;
                    Console.Write("Enter quantity to remove: ");
                    int quantityToRemove = int.Parse(Console.ReadLine());
                    if (inventory[removeItemIndex] < quantityToRemove)
                    {
                        Console.WriteLine($"Not enough {items[removeItemIndex]} in inventory.");
                    }
                    else
                    {
                        inventory[removeItemIndex] -= quantityToRemove;
                        Console.WriteLine($"Removed {quantityToRemove} {items[removeItemIndex]} from inventory.");
                    }
                    break;
                case 3:
                    Console.WriteLine("Current inventory:");
                    for (int i = 0; i < items.Length; i++)
                    {
                        Console.WriteLine($"{items[i]}: {inventory[i]}");
                    }
                    break;
                case 4:
                    Console.WriteLine("Exiting the program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }
        } while (choice != 4);
    }
}
