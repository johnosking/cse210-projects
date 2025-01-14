using System;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {

        DisplayMessage();
        string userName = DisplayName();
        int userNumber = AddNumber();
        int square = SquareNumber(userNumber);
        DisplayResult(userName, square);
    }
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program");
    }
    static string DisplayName()
    {
        
        Console.WriteLine($"Input your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int AddNumber ()
    {
        Console.WriteLine("Please enter your favorite number ");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }
    static int SquareNumber (int userNumber)
    {
        int square = userNumber * userNumber;
        return square;
    }
    static void DisplayResult (string userName, int square)
    {
        Console.WriteLine($"Your user name and squared number is {userName} and {square}");
    }
}
