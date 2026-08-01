using System;
/*FOR CREATIVITY: Added an activity counter in Program.cs that tracks how many times each 
 *    activity has been performed during the session.*/
class Program
{
    static void Main(string[] args)
    {
        int breathingCount = 0;
        int reflectionCount = 0;
        int listingCount = 0;
        string userChoice = "";

        while(userChoice != "5")
        {
        Console.Clear();
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("1. Start breathing activity ");
        Console.WriteLine("2. Start reflecting activity ");
        Console.WriteLine("3. Start listing activity ");
        Console.WriteLine("4. View Activity History");
        Console.WriteLine("5. Quit");
        Console.WriteLine("Select a choice from the menu: ");

        userChoice = Console.ReadLine();

        if(userChoice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                breathingCount++;
            }
            else if (userChoice == "2")
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.Run();
                reflectionCount++;
            }
            else if (userChoice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
                listingCount++;
            }
            else if (userChoice == "4")
            {
                Console.Clear();
                Console.WriteLine("=== Activity History (Current Session) ===");
                Console.WriteLine($"Breathing Activities completed:  {breathingCount}");
                Console.WriteLine($"Reflection Activities completed: {reflectionCount}");
                Console.WriteLine($"Listing Activities completed:    {listingCount}");
                Console.WriteLine($"Total Activities completed:      {breathingCount + reflectionCount + listingCount}");
                
                Console.WriteLine("\nPress Enter to return to the menu.");
                Console.ReadLine();

            }
            else if (userChoice == "5")
            {
                Console.WriteLine("\nGoodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option. Press Enter to try again");
            }

        }
        
        
        
        
    }
}