// Chat GPT really helped through this part, especially with the saving the HashSet, The random words to remove, and figuring it out. its similar to python, just the syntax kicked my butt.


public class ClearWords
{
    private HashSet<string> removedWords = new HashSet<string>();

    public void ClearConsole()
    {
        Console.Clear();
    }

    public string RemoveRandomWords(string scripture, HashSet<string> previouslyRemoved, bool isFirstRun)
    {
        // Split the scripture into words
        string[] words = scripture.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        // Randomly choose indices to remove, but limit to 6 words at most
        Random rnd = new Random();
        int numWordsToRemove = rnd.Next(1, Math.Min(7, words.Length + 1)); // Random number of words to remove (1 to 6, or less if fewer words available)

        // Track indices of words to remove
        HashSet<int> indicesToRemove = new HashSet<int>();
        while (indicesToRemove.Count < numWordsToRemove)
        {
            indicesToRemove.Add(rnd.Next(words.Length)); // Add random index to remove
        }

        // Create a StringBuilder to construct the modified scripture
        System.Text.StringBuilder sb = new System.Text.StringBuilder();

        for (int i = 0; i < words.Length; i++)
        {
            if (indicesToRemove.Contains(i))
            {
                removedWords.Add(words[i]); // Add removed word to the collection
                // Replace each character in the word with "_"
                foreach (char c in words[i])
                {
                    sb.Append("_");
                }
            }
            else
            {
                sb.Append(words[i]); // Keep the word unchanged
            }

            sb.Append(" "); // Add space after each word (even removed ones)
        }

        return sb.ToString().Trim(); // Trim extra spaces at the end before returning
    }

    public HashSet<string> GetRemovedWords()
    {
        return removedWords;
    }
}