namespace KataAnagram
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;

    public class WordDictionary
    {
        public WordDictionary()
        {
            Words = new HashSet<string>(File.ReadAllLines("WordDictionary.txt").Select(o => o.ToUpper()));
        }

        public IEnumerable<string> Words { get; private set; }

        public bool Contains(string word)
        {
            return Words.Count(w => string.Equals(w, word, StringComparison.InvariantCultureIgnoreCase)) >= 1;
        }
    }
}