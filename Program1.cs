using System;
public class Program1
{
    public static void Main(string[] args)
    {
        int choice;
        bool proceed = true;
        float num1;
        float num2;
        float result = 0.0f;
        while (proceed)
        {
            Console.WriteLine("\n Select from 1-4");
            Console.WriteLine("1. Add \n2. Subtract \n3. Multiply \n4.Divide");
            choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Enter the numbers:");
            num1 = float.Parse(Console.ReadLine()); ;
            num2 = float.Parse(Console.ReadLine()); ;
            
            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    break;
                case 2:
                    result = num1 - num2;
                    break;
                case 3:
                    result = num1 * num2;
                    break;
                case 4:
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }
            Console.WriteLine("Result: {0}", result);
            Console.WriteLine("Do you want to continue the operation? Type 'false' to stop");
            if (Console.ReadLine() == "false")
                proceed = false;
        }
    }
}