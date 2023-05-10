using System;
using System.Collections.Generic;

namespace Develop02
{
    class Program
    {
        static void Main(string[] args)
        {
            Entry myEntry = new Entry();
            myEntry.StorePrompt("What is your name?");
            myEntry.StoreResponse("Bridger");
            myEntry.StoreDate("May 8 2023");

            Journal journal = new Journal();
            journal.StoreEntry(myEntry);

            List<Entry> entries = journal.GetEntries();
            foreach (Entry entry in entries)
            {
                string message
                    = $"{entry.GetDate()}\n{entry.GetPrompt()}\n{entry.GetResponse()}";

                Console.WriteLine(message);
            }
        }
    }
}