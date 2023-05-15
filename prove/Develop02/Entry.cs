using System;
using System.Collections.Generic;


namespace Develop02
{
    ///<summary>
    ///The responsibility of an Entry is to store a prompt, response, and date
    public class Entry
    {
        public string prompt;
        public string response;
        public string date;
        
        public string GetEntry()
        {
            return ($"Date: {date} - Prompt: {prompt}\n{response}");
        }

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
            this.date = DateTime.Now.ToString("MM/dd/yyyy");
        }


    }
}