using System.Collections.Generic;

namespace Develop02
{
    public class Journal
    {
        public List<Entry> entries;
        public string journalName;

        public Journal()
        {
            entries = new List<Entry>();
        }

        public string GetJournalName()
        {
            return journalName;
        }
        public List<Entry> GetEntries()
        {
            return entries;
        }

        public void StoreEntry(Entry entry)
        {
            if(!entries.Contains(entry))
            {
                entries.Add(entry);
            }
        }

        public void StoreJournalName(string name){
            journalName = name;
        }
    }
}
