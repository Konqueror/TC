using System;
using System.Linq;
using System.Collections.Generic;

namespace Count_words
{
    class Program
    {
        static void Main()
        {
            string text = "This is the TEXT. Text, text, text – THIS TEXT! Is this the text?";
            char[] separators = { ' ', '.', ',', '!', '–', '?', '-' };
            string insensitiveText = text.ToLower();
            string[] words = insensitiveText.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            
            foreach (var word in words)
            {
                int count = 0;
                if (dictionary.ContainsKey(word))
                {
                    count = dictionary[word];
                }
                dictionary[word] = count + 1;
            }

            foreach (var word in dictionary.OrderBy(key => key.Value))
            {
                Console.WriteLine("{0} -> {1} times", word.Key, word.Value);
            }
        }
    }
}
