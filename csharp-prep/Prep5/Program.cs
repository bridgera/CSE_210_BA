using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        float UserNumber = PromptUserNumber();
        float SquaredNumber = SquareNumber(UserNumber);

        DisplayResult(userName, SquaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string UserName = Console.ReadLine();
        return UserName; 
    }

    static float PromptUserNumber()
    {
        Console.Write("Please enter your number: ");
        string UserNumber = Console.ReadLine();
        float UserFloat = float.Parse(UserNumber);
        return UserFloat; 
    }

    static float SquareNumber(float ToBeSquared)
    {
        float SquaredValue = ToBeSquared * ToBeSquared;
        return SquaredValue;
    }

    static void DisplayResult(string UserName, float SquaredValue)
    {
        Console.WriteLine($"{UserName}, the square of your number is {SquaredValue}");
    }

}
