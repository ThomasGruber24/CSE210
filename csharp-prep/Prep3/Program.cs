using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Random rnd = new Random();
        int magicNumber = rnd.Next(1, 100);
        Console.WriteLine("I have generated a Magic Number, It is time for you to guess!");
        int guess = 0; // This is to initialize the guess. it will never eaqual the random number due to how the random number works
        int count = 0; // This is to initialize the count.


        do
        {
        Console.WriteLine("What is your guess?");
        guess = int.Parse(Console.ReadLine());

            if (guess > magicNumber)
            {
                Console.WriteLine("You are too high");
                count += 1;
            }
            else
            {
                Console.WriteLine("You are too low");
                count +=1;
            }

        } while(magicNumber != guess); // I decided to use a do while loop, it seems easy and very similar to the while loop in python.
        Console.WriteLine("You did it! You got the magic number!");
        Console.WriteLine($"The magic number was {magicNumber}, you got it in {count} number of guesses.");
    }
}