using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("I want you to give me a list of numbers. Enter 0 when finished");

        List<int> numbers = new List<int>();
        int largestNum = 0;
        int smallestPosNum = 0;
        int smallestNegNum = 0;
        int sum = 0;
        int enteredNum = 1;
        float count = 0;
        float avgNum = 0; // the average total
        float convertNum = 0; // to convert my number later on in the program

        do // This loop is going to be purely for adding ints to the list
        {
            Console.Write("Enter a number: ");
            enteredNum = int.Parse(Console.ReadLine());
            if (enteredNum != 0) // 0 is not to be in the list
            {
                numbers.Add(enteredNum);
            }
            
        } while (enteredNum != 0);
        Console.WriteLine("Thank you now calculating...");

        numbers.Sort(); // You know I could spend a long time sorting the list, but as a good programmer, I'm gonna be a bit lazy :D

        foreach (int number in numbers) // Finds the Largest and Smallest
        {
            if (number > largestNum)
            {
                largestNum = number;
            }
            if (number < smallestPosNum && number > 0) // well it returns 0 when I dont know why, but thats ok, moving on
            {
                smallestPosNum = number;
            }
            if (number < smallestNegNum && number < 0)
            {
                smallestNegNum = number;
            }
            sum += number;
            count += 1;
        }

        // Math section
        convertNum = (float)sum;
        avgNum = convertNum / count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avgNum}");
        Console.WriteLine($"The largest number is: {largestNum}");
        Console.WriteLine($"The smallest positive number is: {smallestPosNum}, The smallest number is: {smallestNegNum}");
        Console.WriteLine("here is your sorted list: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }


    }
}