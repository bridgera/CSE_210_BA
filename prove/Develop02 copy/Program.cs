using System;
using System.Collections.Generic;

namespace Develop02
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            FileHandler fileHandler = new FileHandler();
            PromptHandler promptHandler = new PromptHandler();

            while (true)
            {
                Console.WriteLine("Please select one of the following choices:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1": // Write 
                        Entry myEntry = new Entry();
                        string prompt = promptHandler.GetRandomPrompt();
                        myEntry.StorePrompt(prompt);
                        Console.Write($"Prompt: {prompt}\nEnter response: ");
                        string response = Console.ReadLine();
                        myEntry.StoreResponse(response);
                        myEntry.StoreDate(DateTime.Now.ToString("MM/dd/yyyy"));
                        journal.StoreEntry(myEntry);
                        break;

                    case "2": // Display
                        List<Entry> entries = journal.GetEntries();
                        foreach (Entry entry in entries)
                        {
                            Console.WriteLine(entry);
                        }
                        break;

                    case "3": // Load
                        Console.Write("Enter the journal filename you would like to load: ");
                        string loadFilename = Console.ReadLine();
                        journal = fileHandler.Load(loadFilename);
                        break;

                    case "4": // Save
                        Console.Write("Enter a filename for saving the journal: ");
                        string saveFilename = Console.ReadLine();
                        fileHandler.Save(journal, saveFilename);
                        break;

                    case "5": // Quit
                        return;

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }
}
