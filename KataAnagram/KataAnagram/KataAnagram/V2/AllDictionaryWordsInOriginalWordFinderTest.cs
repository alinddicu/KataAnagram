namespace KataAnagram.V2
{
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class AllDictionaryWordsInOriginalWordFinderTest
    {
        private AllDictionaryWordsInOriginalWordFinder _finder;

        [TestInitialize]
        public void Initialize()
        {
            _finder = new AllDictionaryWordsInOriginalWordFinder();
        }

        [TestMethod]
        public void Test()
        {
            var results = _finder.Find("RARE").ToArray();

            Check.That(results.Length).IsEqualTo(16);
        }
    }
}