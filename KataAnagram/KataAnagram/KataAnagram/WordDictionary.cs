namespace KataAnagram
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;

    public class WordDictionary
    {
        private readonly HashSet<string> _words;

        public WordDictionary()
        {
            _words = new HashSet<string>(File.ReadAllLines("WordDictionary.txt").Select(o => o.ToUpper()));
        }

        public bool Contains(string word)
        {
            return _words.SingleOrDefault(w => string.Equals(w, word, StringComparison.InvariantCultureIgnoreCase)) != null;
        }
    }
}