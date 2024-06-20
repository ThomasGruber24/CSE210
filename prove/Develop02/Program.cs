using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        PromptGen promptGen = new PromptGen();
        LogEntry logEntry = new LogEntry();
        bool endPorgram = false;
        string date;

        Console.WriteLine("Welcome to the journal program!");
        Console.WriteLine("What would you like to do?");
        do{

            Console.Write("1. Enter Journal Entry   2. Read Journal Entry   3. Quit Program: ");
            int userResponse = int.Parse(Console.ReadLine());
            if (userResponse == 1)
            {
                Random rnd = new Random();
                int ranPromptNum = rnd.Next(7); // Generate a random number 6

                promptGen.ranPromptNumSet = ranPromptNum;

                Console.Write("What is today's date (yyyy-MM-dd): ");
                date = Console.ReadLine();

                string generatedPrompt = promptGen.genPrompt();

                Console.WriteLine("Write something to go with this prompt: ");
                Console.Write(generatedPrompt);
                string journalEntry = Console.ReadLine();

                logEntry.entryDate = date;
                logEntry.entryText = journalEntry;

                CsvExporter.ExportToCsv(logEntry);

            }
            else if (userResponse == 2)
            {
                static string[] ReadCsvFile()
                {
                    string filePath = @"Log.csv"; // File path for the CSV file

                     // Check if the file exists
                    if (!File.Exists(filePath))
                    {
                        Console.WriteLine("Log.csv file not found.");
                        return new string[0]; // Return an empty array
                    }

                    // Read all lines from the CSV file
                    string[] lines = File.ReadAllLines(filePath);

                    return lines;
                }
                string[] lines = File.ReadAllLines(FilePath);
            }
            else
            {
                endPorgram = true;
            }

        } while (endPorgram == false);
    }
}