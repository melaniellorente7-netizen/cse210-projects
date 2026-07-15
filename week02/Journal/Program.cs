// For creativity I added an extra option, number 6 that is the functionality of search by words on the user entries
using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int userChoice = 0;

        while (userChoice != 5)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("6. Search Entries");
            Console.WriteLine("What would you like to do? ");

            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();

                string currenDate = DateTime.Now.ToShortDateString();

                Entry newEntry = new Entry();
                newEntry._date = currenDate;
                newEntry._promptText = prompt;
                newEntry._entryText = response;

                myJournal.AddEntry(newEntry);
                Console.WriteLine("Entry saved successfully!");
            }
            else if (userChoice == 2)
            {
                Console.WriteLine("\n --- Journal Entries ---");
                myJournal.DisplayAll();
            }
            else if (userChoice == 3)
            {
                Console.Write("What is the file name? ");
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);
                Console.WriteLine("Journal loaded successfully");
            }
            else if (userChoice == 4)
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
                Console.WriteLine("Journal saved to file successfully!");
            }
            else if (userChoice == 6)
            {
                Console.Write("What words are you looking for?: ");
                string keyword = Console.ReadLine();
                Console.WriteLine("\n--- Search Results ---");
                myJournal.SearchEntries(keyword);
                
            }
        }
        Console.WriteLine("\nThanks for writing on your journal today! See you tomorrow!");
    }
}