using System;
using System.IO;

namespace Develop02
{
    public class FileHandler
    {
        string journalName;
        string dateString;
        string filePath;
        string directoryPath;
 
        public FileHandler(Journal currentJournal)
        {
            journalName = currentJournal.GetJournalName();
            dateString = DateTime.Now.ToString("yyyy-MM-dd_hh-mm-ss");
            directoryPath = Path.Combine("data", "journals", journalName);
            filePath = Path.Combine(directoryPath, $"{dateString}.txt");
        }
        
        public void CreateDirectory()
        {
            if(!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
                Console.WriteLine($"Directory created at {directoryPath}");
            }
        }

        public void Save(string entry)
        {
            CreateDirectory();
            filePath = Path.Combine(directoryPath, $"{dateString}.txt");
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(entry);
            }
        }

        public void Display()
        {
            CreateDirectory();
            string[] filePaths = Directory.GetFiles(directoryPath, "*.txt");
            foreach (string file in filePaths)
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    string content = reader.ReadToEnd();
                    Console.WriteLine(content);
                }
            }
        }
    }
}
