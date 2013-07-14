using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace FindWords
{
    class Program
    {
        static void Main(string[] args)
        {
            //The 100MB files is not uploaded because of the server. The Trie class is taken from the internet.
            ITrie trie = TrieFactory.GetTrie();
            using (StreamReader sr = new StreamReader("../../randomText.txt"))
            {
                Console.WriteLine("Getting the text to the memory");
                String line = sr.ReadToEnd();
                string[] wordsOnLine = line.Split(' ');
                for (int i = 0; i < wordsOnLine.Length; i++)
                {
                    trie.AddWord(wordsOnLine[i]);
                }
            }
            Console.WriteLine("Seraching for lord 'lorem'");
            Console.WriteLine(trie.WordCount("lorem"));
            Console.WriteLine(trie.WordCount("ipsum"));
        }
    }
}
