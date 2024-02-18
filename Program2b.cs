using System;
using System.Collections.Generic;
public class Program2b
{
    public static void Main()
    {
        Dictionary<int, string> country = new Dictionary<int, string>();
        Console.WriteLine("Enter the number of items: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter the counry code and name: ");
            int code = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            country.Add(code, name);
        }
        foreach (KeyValuePair<int, string> entry in country)
        {
            Console.WriteLine(entry.Key + " : " + entry.Value);
        }
        Console.WriteLine("Enter key to find value: ");
        int pos = int.Parse(Console.ReadLine());
        Console.WriteLine("Country - {0} : {1}", pos, country[pos]);
    }
}