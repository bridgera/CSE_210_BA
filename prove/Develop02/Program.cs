using System;
using System.Collections.Generic;
using System.IO;

namespace Develop02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Journal journal = new Journal();
            journal.StoreJournalName("Base");
            FileHandler fileHandler = new FileHandler(journal);
            


            while (true)
            {
                Console.WriteLine("Please select one of the following choices:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3  Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1": // Write 
                        Entry myEntry = new Entry();
                        Console.Write("Enter prompt: ");
                        string prompt = Console.ReadLine();
                        myEntry.StorePrompt(prompt);
                        Console.Write("Enter response: ");
                        string response = Console.ReadLine();
                        myEntry.StoreResponse(response);
                        myEntry.StoreDate(DateTime.Now.ToString("MM/dd/yyyy"));

                        journal.StoreEntry(myEntry);
                        break;

                    case "2": // Display
                        fileHandler.Display();
                        break;

                    case "3": // Load
                        Console.Write("Enter the journal you would like to access: ");
                        string journalTitle = Console.ReadLine();
                        journal.StoreJournalName(journalTitle);
                        fileHandler.CreateDirectory();
                        // fileHandler.Load();
                        break;

                    case "4": // Save 

                        foreach (Entry entry in journal.GetEntries())
                        {
                            fileHandler.Save(entry.GetEntry());
                        }
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
