using System.Reflection.Metadata.Ecma335;

public class PromptGen
{
        public int ranPromptNumSet { get; set; }
        public string genPrompt()
        {
            string prompt;

            if (ranPromptNumSet == 1)
            {
                prompt = "How was your day today?";
            }
            else if (ranPromptNumSet == 2)
            {
                prompt = "Who was the most interesting person you interacted with today?";
            }
            else if (ranPromptNumSet == 3)
            {
                prompt = "What was the coolest thing you saw today";
            }
            else if (ranPromptNumSet == 4)
            {
                prompt = "How did you incorperate the Lord into your life?";
            }
            else if (ranPromptNumSet == 5)
            {
                prompt = "What was the strongest emotion you felt today? Both good and bad.";
            }
            else
            {
                prompt = "If you could take something back from today what would it be?";
            }

            return prompt;
        }
}