using System;
using System.Collections.Generic;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbersList = new List<int>();

        int userList = -1;

        while (userList != 0)
        {
            Console.WriteLine("Enter a number (O to end)");
            string answer = Console.ReadLine();
            userList  =  int.Parse(answer);
            numbersList.Add(userList);

        }

        int sum = 0;
        foreach (int number in  numbersList)
        {
            sum += number;

        }
        Console.WriteLine($"The sum is: {sum}");

        int average = sum / numbersList.Count;
        Console.WriteLine($"The Average is {average}");

    
        int max = numbersList[0];

        foreach (int number in numbersList)
        {
            if (number > max)
            {
                max = number;

            }
        }
        Console.WriteLine($"The Max number is {max}");
    }
}