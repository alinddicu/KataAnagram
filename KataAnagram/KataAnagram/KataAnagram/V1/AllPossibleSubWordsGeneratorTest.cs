namespace KataAnagram
{
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class AllPossibleSubWordsGeneratorTest
    {
        private AllPossibleSubWordsGenerator _generator;

        [TestInitialize]
        public void Initialize()
        {
            _generator = new AllPossibleSubWordsGenerator();
        }

        [TestMethod]
        public void GivenRareWordWhenGenerateThenSubwordsAreOnlyExisting()
        {
            var moreThanExpectedOutput = new[]{
                "R",
                "A",
                "E",
                "RA",
                "RR",
                "RE",
                "AR",
                "ER",
                "AE",
                "EA",
                "RAE",
                "REA",
                "ARR",
                "ARE",
                "ERA",
                "ERR",
                "EAR",
                "RARE",
                "REAR"
            };

            var output = _generator.Generate("RARE").ToList();
            output.ForEach(w => System.Diagnostics.Trace.WriteLine(w));

            Check.That(moreThanExpectedOutput).Contains(output);
        }
    }
}