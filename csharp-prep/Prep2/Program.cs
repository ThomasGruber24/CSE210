using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("What is your grade (whole numbers only)? ");
        string grade = Console.ReadLine();
        int gradePercent = int.Parse(grade);

        string gradeLetter = "";

        if (gradePercent >= 90)
        {
            gradeLetter = "A";
            Console.WriteLine("You passed! A!!!!");
        }
        else if (gradePercent >= 80)
        {
            gradeLetter = "B";
            Console.WriteLine("You passed! B!");
        }
        else if (gradePercent >= 70)
        {
            gradeLetter = "C";
            Console.WriteLine("You passed! C.");
        }
        else if (gradePercent >= 60)
        {
            gradeLetter = "D";
            Console.WriteLine("You failed, with a D :/");
        }
        else
        {
            gradeLetter = "F";
            Console.WriteLine("You failed... F :/");
        }
    }
}