using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementTrie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trie trie = new Trie();
            trie.Insert("apple");
            trie.Search("apple");
            trie.Search("app");
            trie.StartsWith("app");
            trie.Insert("app");
            trie.Search("app");
        }
        public class Trie
        {
            List<string> allWords = new List<string>();
            public Trie()
            {
                allWords = new List<string>();
            }

            public void Insert(string word)
            {
                Console.WriteLine(word);
                allWords.Add(word);
            }

            public bool Search(string word)
            {
                Console.WriteLine(allWords.Contains(word));
                return allWords.Contains(word);
            }

            public bool StartsWith(string prefix)
            {
                Console.WriteLine(allWords.Any(x => x.StartsWith(prefix)));
                return allWords.Any(x => x.StartsWith(prefix));
            }
        }
    }
}
