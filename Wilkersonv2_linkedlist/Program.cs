using System;

// Header Comment
Console.WriteLine("// First or Nickname Lastname");
Console.WriteLine("// IT113");
Console.WriteLine("// NOTES: A sorted linked list implementation without top-level statements.");

LinkedList myList = new();
int choice;

do
{
    Console.WriteLine("\nMenu:");
    Console.WriteLine("1. Add item");
    Console.WriteLine("2. Remove item");
    Console.WriteLine("3. Search for item");
    Console.WriteLine("4. Print");
    Console.WriteLine("5. Exit");
    Console.Write("Enter your choice: ");

    choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.Write("Enter the name: ");
#pragma warning disable CS8604 // Possible null reference argument.
            myList.Add(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.
            break;

        case 2:
            Console.Write("Enter the name to remove: ");
#pragma warning disable CS8604 // Possible null reference argument.
            bool removed = myList.Remove(item: Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.
            Console.WriteLine(removed ? "Removed successfully." : "Item not found.");
            break;

        case 3:
            Console.Write("Enter the name to search: ");
            bool found = myList.Contains(Console.ReadLine());
            Console.WriteLine(found ? "Item found." : "Item not found.");
            break;

        case 4:
            myList.PrintAllNodes();
            break;

        case 5:
            Console.WriteLine("Exiting...");
            break;

        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }

} while (choice != 5);
