namespace KataAnagram
{
    using System.Collections.Generic;
    using System.IO;

    public class WordDictionary
    {
        private readonly HashSet<string> _words;

        public WordDictionary()
        {
            _words = new HashSet<string>(File.ReadAllLines("WordDictionary.txt"));
        }

        public bool Contains(string word)
        {
            return _words.Contains(word);
        }
    }
}