using System;
using System.Collections.Generic;

namespace Develop02
{
    public class PromptHandler
    {
        private List<string> prompts;

        public PromptHandler()
        {
            prompts = new List<string>
            {
                "Who was the most interesting person you interacted with today?",
                "What was the best part of your day?",
                "How did you see the hand of the Lord in your life today?",
                "What was the strongest emotion you felt today?",
                "If you had one thing you could do over today, what would it be?"
            };
        }

        public string GetRandomPrompt()
        {
            Random random = new Random();
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
    }
}
