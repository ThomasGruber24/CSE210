using System;

class Program
{
    static void Main(string[] args)
    {
        //I used some of the code from the sample solution I wanted to add things to make it my own
        //Below this set of code is my own code to make it a user orented program.

        Console.WriteLine("Hello, You have two options, you can see the code I wrote or the sample solution's code");
        Console.Write("You will need to type 1 or 2, 1. sample solution    2. my own work: ");
        string userAnswer = Console.ReadLine();

        if (userAnswer == "1")
        {
            Fraction f1 = new Fraction(); //From my understanding this is just using the default numbers as both the top and bottom.
            Console.WriteLine(f1.GetFractionString());
            Console.WriteLine(f1.GetDecimalValue());

            Fraction f2 = new Fraction(5); //Similar to the top I would assume this is deciding what the top number is.
            Console.WriteLine(f2.GetFractionString());
            Console.WriteLine(f2.GetDecimalValue());

            Fraction f3 = new Fraction(3, 4); //This one is deciding both the top and bottom number respectively.
            Console.WriteLine(f3.GetFractionString());
            Console.WriteLine(f3.GetDecimalValue());

            Fraction f4 = new Fraction(1, 3); //This is to show it that it can do different types of fractions.
            Console.WriteLine(f4.GetFractionString());
            Console.WriteLine(f4.GetDecimalValue());
        }
        else
        {
            Console.WriteLine("You selected my work!");
            Console.Write("Please input one number, this will be used as our top number: ");
            int _topNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"The top number is {_topNumber}");
            Console.Write("Please give me the bottom number: ");
            int _bottomNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"The bottom number is {_bottomNumber}");

            //To use the code provided in the solution as a guide I will use it, but I will comment what I think it is doing
            //This is to show that I am starting to understand what is going, going into this program I had a hard time with it
            //But this is more for my own understanding.

            Fraction fCustom = new Fraction(_topNumber, _bottomNumber); // This line calls the Fraction Meathods and makes the numbers
            // Whatever the user has inputed in this case.
            Console.WriteLine(fCustom.GetFractionString()); // This line is quite litterally printing the fraction as a "x/y" fraction.
            Console.WriteLine(fCustom.GetDecimalValue()); // This one goes to the double decimal function. What that does is it converts the
            // numbers given by the user and makes a decimal, something I did was limit it to two decimal places. That goes for 1/3 as well.
            // It was very similar to how Python does it, while using a the math.round.

        }


    }
}