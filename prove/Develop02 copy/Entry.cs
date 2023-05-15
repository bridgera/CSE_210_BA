using System;

namespace Develop02
{
    public class Entry
    {
        private string prompt;
        private string response;
        private string date;

        public void StorePrompt(string prompt)
        {
            this.prompt = prompt;
        }

        public void StoreResponse(string response)
        {
            this.response = response;
        }

        public void StoreDate(string date)
        {
            this.date = date;
        }

        public override string ToString()
        {
            return $"Date: {date}\nPrompt: {prompt}\nResponse: {response}\n";
        }
    }
}
