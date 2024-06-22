using System;

class Program
{
    static void Main(string[] args)
    {
        Storage st = new Storage();
        ClearWords clear = new ClearWords();
        Random rnd = new Random();
        int randomNumbGen = rnd.Next(1, 6); // Generate a random number between 1 and 5
        st.randomNumb = randomNumbGen;

        bool endProgram = false;
        bool isFirstRun = true;
        HashSet<string> removedWords = new HashSet<string>();

        Console.WriteLine("Hello, Welcome to scripture mastery!");

        do
        {
            Console.Write("To end this program write 'quit', press enter to move forward: ");
            string userInput = Console.ReadLine();
            if (userInput == "quit")
            {
                endProgram = true;
            }
            else
            {
                clear.ClearConsole();
                
                string scripture = st.genScripture();
                string randomCleared = clear.RemoveRandomWords(scripture, removedWords, isFirstRun);
                removedWords.UnionWith(clear.GetRemovedWords()); // Add newly removed words to the collection
                Console.WriteLine($"Modified Scripture: {randomCleared}");
                
                if (isFirstRun)
                {
                    isFirstRun = false;
                }
            }

        } while (!endProgram);
    }
}