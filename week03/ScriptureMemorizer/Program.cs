/* FOR CREATIVITY:
After the user memorized the first scripture it is prompted them to practice with another one from a predefine scripture list.
The game continues with the next scripture and the user still can exit the program at any point.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptureList = new List<Scripture>();

        Reference reference1 = new Reference("Proverbs", 3, 5, 6);
        scriptureList.Add(new Scripture(reference1, "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths."));

        Reference reference2 = new Reference("1 Nephy", 3, 7);
        scriptureList.Add(new Scripture(reference2, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."));

        Reference reference3 = new Reference("Alma", 37, 37);
        scriptureList.Add(new Scripture(reference3, "Counsel with the Lord in all thy doings, and he will direct thee for good; yea, when thou liest down at night lie down unto the Lord, that he may watch over you in your sleep; and when thou risest in the morning let thy heart be full of thanks unto God; and if ye do these things, ye shall be lifted up at the last day."));

        int currentScriptureIndex = 0;

        while (currentScriptureIndex < scriptureList.Count)
        {
            Scripture currentScripture = scriptureList[currentScriptureIndex];

            while (true)
            {
                Console.Clear();
                Console.WriteLine(currentScripture.GetDisplayText());
                Console.WriteLine();

                if (currentScripture.IsCompletelyHidden())
                {
                    Console.WriteLine("Good Job! You have memorized this scripture!");
                    Console.WriteLine("Do you want to memorize another scripture? (y/n)");
                    string answer = Console.ReadLine().ToLower();

                    if (answer == "y")
                    {
                        currentScriptureIndex++;
                        break;
                    }
                    else
                    {
                        currentScriptureIndex = scriptureList.Count;
                        break;
                    }
                }
                Console.WriteLine("Press ENTER to hide words or write 'quit' to exit de program");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    currentScriptureIndex = scriptureList.Count;
                    break;
                }
                currentScripture.HideRandomWords(3);
            }
        }
        Console.Clear();
        Console.WriteLine("Thanks for playing!");
    }
}