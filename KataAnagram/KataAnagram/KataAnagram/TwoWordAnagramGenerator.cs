namespace KataAnagram
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class TwoWordAnagramGenerator
    {
        private static readonly WordDictionary WordDictionary = new WordDictionary();
        private StringBuilder Output = new StringBuilder();
        private string Inputstring;

        private readonly AllLettersCombinationsGenerator _allLettersCombinationsGenerator = new AllLettersCombinationsGenerator();

        private List<string> _allLettersCombinations;

        public IEnumerable<string> Generate(string originalString)
        {
            _allLettersCombinations = _allLettersCombinationsGenerator.Generate(originalString).ToList();

            return Enumerable.Empty<string>();
        }
    }
}