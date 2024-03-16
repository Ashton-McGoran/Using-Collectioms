using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // a) Queue<T> collection
        Queue<int> queue = new Queue<int>();
        AddItemsToQueue(queue);
        Console.WriteLine("Queue contains item '3': " + queue.Contains(3));
        queue.TryDequeue(out int removedItem); // Remove an item
        Console.WriteLine("Number of items in the queue: " + queue.Count);
        Console.WriteLine("Items in the queue:");
        PrintCollection(queue);
        Console.WriteLine();

        // b) PriorityQueue<T> collection (Placeholder)

        // c) Stack<T> collection
        Stack<int> stack = new Stack<int>();
        AddItemsToStack(stack);
        Console.WriteLine("Stack contains item '3': " + stack.Contains(3));
        stack.Pop(); // Remove an item
        Console.WriteLine("Number of items in the stack: " + stack.Count);
        Console.WriteLine("Items in the stack:");
        PrintCollection(stack);
        Console.WriteLine();

        // d) LinkedList<T> and LinkedNodeList<T> collections
        LinkedList<int> linkedList = new LinkedList<int>();
        AddItemsToLinkedList(linkedList);
        Console.WriteLine("First node value: " + linkedList.First.Value);
        Console.WriteLine("Last node value: " + linkedList.Last.Value);
        linkedList.AddAfter(linkedList.Find(3), 6); // Add 6th item to the middle
        linkedList.RemoveLast(); // Remove last node
        Console.WriteLine("Number of items in linked list: " + linkedList.Count);
        Console.WriteLine("Items in the linked list:");
        PrintCollection(linkedList);
        Console.WriteLine();

        // e) Dictionary<TKey, TValue> collection
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        AddItemsToDictionary(dictionary);
        Console.WriteLine("Keys:");
        PrintCollection(dictionary.Keys);
        Console.WriteLine("Values:");
        PrintCollection(dictionary.Values);
        Console.WriteLine("Keys and Values:");
        foreach (var pair in dictionary)
        {
            Console.WriteLine(pair.Key + ": " + pair.Value);
        }
        dictionary.Remove("Three"); // Remove an item
        Console.WriteLine("Number of items in dictionary: " + dictionary.Count);
        Console.WriteLine();

        // f) SortedList<TKey, TValue> collection (Placeholder)

        // g) HashSet<T> collection (Placeholder)

        // h) List<T> collection
        List<int> list = new List<int>();
        AddItemsToList(list);
        Console.WriteLine("Sorted List:");
        list.Sort();
        PrintCollection(list);
        list.Remove(3); // Remove an item
        Console.WriteLine("Sorted List in Reverse:");
        list.Reverse();
        PrintCollection(list);
    }

    static void AddItemsToQueue(Queue<int> queue)
    {
        Console.WriteLine("Enter 5 integers to add to the queue:");
        for (int i = 0; i < 5; i++)
        {
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                queue.Enqueue(num);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
                i--; // Retry for this iteration
            }
        }
    }

    static void AddItemsToStack(Stack<int> stack)
    {
        Console.WriteLine("Enter 5 integers to add to the stack:");
        for (int i = 0; i < 5; i++)
        {
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                stack.Push(num);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
                i--; // Retry for this iteration
            }
        }
    }

    static void AddItemsToLinkedList(LinkedList<int> linkedList)
    {
        Console.WriteLine("Enter 5 integers to add to the linked list:");
        for (int i = 0; i < 5; i++)
        {
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                linkedList.AddLast(num);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
                i--; // Retry for this iteration
            }
        }
    }

    static void AddItemsToDictionary(Dictionary<string, int> dictionary)
    {
        Console.WriteLine("Enter 5 key-value pairs to add to the dictionary (e.g., key=value):");
        for (int i = 0; i < 5; i++)
        {
            string input = Console.ReadLine();
            string[] parts = input.Split('=');
            if (parts.Length == 2)
            {
                if (int.TryParse(parts[1], out int value))
                {
                    dictionary.Add(parts[0], value);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter an integer value.");
                    i--; // Retry for this iteration
                }
            }
            else
            {
                Console.WriteLine("Invalid input format. Please use 'key=value' format.");
                i--; // Retry for this iteration
            }
        }
    }

    static void AddItemsToList(List<int> list)
    {
        Console.WriteLine("Enter 5 integers to add to the list:");
        for (int i = 0; i < 5; i++)
        {
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                list.Add(num);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
                i--; // Retry for this iteration
            }
        }
    }

    static void PrintCollection<T>(IEnumerable<T> collection)
    {
        foreach (var item in collection)
        {
            Console.WriteLine(item);
        }
    }
}
