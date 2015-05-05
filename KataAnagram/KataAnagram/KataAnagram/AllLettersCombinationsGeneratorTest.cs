namespace KataAnagram
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class AllLettersCombinationsGeneratorTest
    {
        private AllLettersCombinationsGenerator _generator;

        [TestInitialize]
        public void Initialize()
        {
            _generator = new AllLettersCombinationsGenerator();
        }

        [TestMethod]
        public void GivenXyxWhenGenerateThenReturnAllCombinations()
        {
            var combinations = _generator.Generate("xyx");

            Check.That(combinations).ContainsExactly(new[] { "x", "xy", "xyx", "xx", "y", "yx", "x" });
        }
    }
}