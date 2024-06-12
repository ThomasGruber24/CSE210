using System;

class Program
{
    static void Main(string[] args)
    {
        OpeningMessage();

        string userName = UserName();
        string quest = Quest();
        int favNum = FavoriteNumber();
        int squareNum  = SquaredNumber(favNum);



        Console.WriteLine($"Your name is: {userName}");
        Console.WriteLine($"Your favorite number is: {favNum}");
        Console.WriteLine($"Your favorite color squared is: {squareNum}");
        Console.WriteLine($"Your quest is: {quest}");
    }
    static void OpeningMessage()
    {
        Console.WriteLine("STOP! Who would cross the bridge of death must answer me these questions 3... There the other side he see.");
    }

    static string UserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();

        return name;
    }
    static int FavoriteNumber()
    {
        Console.Write("Whate is your favorite Number? ");
        int num = int.Parse(Console.ReadLine());

        return num;
    }
    static int SquaredNumber(int num)
    {
        int square = num * num;
        return square;
    }
    static string Quest()
    {
        Console.Write("What is your quest? ");
        string userQuest = Console.ReadLine();

        return userQuest;
    }
}