using System;
using System.IO;
using System.Collections.Generic;

namespace Develop02
{
    public class FileHandler
    {
        public void Save(Journal journal, string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Entry entry in journal.GetEntries())
                {
                    writer.WriteLine(entry.ToString());
                }
            }
        }

        public Journal Load(string filename)
        {
            Journal journal = new Journal();

            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Entry entry = new Entry();
                    string[] parts = line.Split('\n');
                    if (parts.Length == 3)
                    {
                        string datePart = parts[0].Substring("Date: ".Length);
                        string promptPart = parts[1].Substring("Prompt: ".Length);
                        string responsePart = parts[2].Substring("Response: ".Length);

                        entry.StoreDate(datePart);
                        entry.StorePrompt(promptPart);
                        entry.StoreResponse(responsePart);

                        journal.StoreEntry(entry);
                    }
                }
            }

            return journal;
        }
    }
}
