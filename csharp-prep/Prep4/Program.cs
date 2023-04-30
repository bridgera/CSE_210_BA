using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<float> user_list = new List<float>();
        float largest_value = 0;
        float smallest_value = 99999;


        string user_input = "";
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while(user_input != "0")
        {
            Console.Write("Enter number: ");
            user_input = Console.ReadLine();
            float user_int = float.Parse(user_input);
            user_list.Add(user_int);
        }

        foreach (float item in user_list)
        {
            if(item > largest_value)
            {
                largest_value = item;
            }

            if(item < smallest_value && item > 0)
            {
                smallest_value = item;
            }
        }

        float sum = user_list.Sum();
        float avg = sum / ((float)user_list.Count - 1);

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {largest_value}");
        Console.WriteLine($"The smallest positive number is: {smallest_value}");
        Console.WriteLine("The sorted list is:");

        user_list.Sort(); // Sort the list in ascending order

        foreach (float item in user_list)
        {
            Console.WriteLine(item);
        }
    }
}
