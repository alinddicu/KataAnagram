namespace KataAnagram
{
    using System.Linq;
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
        [Ignore]
        public void GivenXyWhenGenerateThenReturnAllCombinations()
        {
            var combinations = _generator.Generate("xy").ToList();

            Check.That(combinations).HasSize(4);
            Check.That(combinations).ContainsExactly(new[] { "x", "y", "xy", "yx" });
        }

        [TestMethod]
        [Ignore]
        public void GivenXyxWhenGenerateThenReturnAllCombinations()
        {
            var combinations = _generator.Generate("xyx").ToList();

            Check.That(combinations).HasSize(8);
            Check.That(combinations).Contains(new[] { "x", "y", "xx", "xy", "yx", "xyx", "xxy", "yxx" });
        }
    }
}