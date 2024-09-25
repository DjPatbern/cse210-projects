using System;

class Program
{
    static void Main(string[] args)
    {
        ShowWelcomeMessage();

        string userName = HandleUserName();
        int favoriteNumber = HandleFavoriteNumber();

        int squaredNumber = SquareNumber(favoriteNumber);

        ShowResult(userName, squaredNumber);
    }

    static void ShowWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string HandleUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int HandleFavoriteNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void ShowResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }

}