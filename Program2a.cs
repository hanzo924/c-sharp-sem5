using System;
using System.Collections.Generic;
public class HelloWorld
{
    public static void Display(List<string> items)
    {
        Console.WriteLine("Items in Invetory are: \n");
        for (int i = 0; i < items.Count; i++)
        {
            Console.Write(String.Format("{0}-{1} \n", i, items[i]));
        }
    }
    public static void Insert(List<string> items)
    {
        bool add = true;
        while (add)
        {
            Console.WriteLine("\n Enter the postion and the item");
            int pos = Convert.ToInt32(Console.ReadLine());
            string item = Console.ReadLine();
            items.Insert(pos, item);
            Console.WriteLine("Enter false to stop adding");
            add = Convert.ToBoolean(Console.ReadLine());
        }
    }
    public static void Delete(List<string> items)
    {
        bool add = true;
        while (add)
        {
            Console.WriteLine("\n Enter the item to be removed");
            string item = Console.ReadLine();
            items.Remove(item);
            Console.WriteLine("Enter false to stop deleting");
            add = Convert.ToBoolean(Console.ReadLine());
        }
    }
    public static void Main()
    {
        List<string> items = new List<string>();
        string value;
        Console.WriteLine("Enter Your Name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter number of items: ");
        int n = Convert.ToInt32(Console.ReadLine());
        // Insert 'n' items
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter item {0}: ", i);
            value = Console.ReadLine();
            items.Add(value);
        }
        // Display
        Display(items);
        Insert(items);
        Display(items);
        Delete(items);
        Display(items);
    }
}