using System.Collections.Generic;

namespace Develop02
{
    public class Journal
    {
        private List<Entry> entries;

        public Journal()
        {
            entries = new List<Entry>();
        }

        public void StoreEntry(Entry entry)
        {
            entries.Add(entry);
        }

        public List<Entry> GetEntries()
        {
            return entries;
        }
    }
}