﻿namespace KataAnagram.V2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class TwoWordAnagramGeneratorTest
    {
        public static readonly List<string> DocumentingTwoWordsAnagram = new List<string>
        {
            "CODE MUNTING",
            "CODEN MUTING",
            "COED MUNTING",
            "COME DUNTING",
            "CONED MUTING",
            "CUM DENOTING",
            "CUMIN TONGED",
            "CUNT MENDIGO",
            "DECO MUNTING",
            "DICOT GUNMEN",
            "DINGO CENTUM",
            "DOING CENTUM",
            "DUCI TONGMEN",
            "DUCT OMENING",
            "DUNG CENTIMO",
            "DUNG TONEMIC",
            "DUNT GENOMIC",
            "EDUCT MIGNON",
            "GENOM INDUCT",
            "GIN DOCUMENT",
            "GNOME INDUCT",
            "GUID CONTEMN",
            "MED COUNTING",
            "MENO DUCTING",
            "MOC UNTINGED",
            "MOUNT CEDING",
            "MUCIN TONGED",
            "MUT ENCODING",
            "MUTE CONDIGN",
            "MUTED CONING",
            "MUTON CEDING",
            "NOME DUCTING",
            "NONCE MIDGUT",
            "NOTUM CEDING",
            "OMEN DUCTING",
            "TUNED COMING",
            "TUNED GNOMIC",
            "TUNG DEMONIC",
            "UNGOT MINCED",
            "UNMET CODING",
            "DOCUMENTING"
        };

        private TwoWordAnagramGenerator _generator;

        [TestInitialize]
        public void Initialize()
        {
            _generator = new TwoWordAnagramGenerator();
        }

        [TestMethod]
        public void GivenWordDocumentingWhenGenerateThenOutputIsExact()
        {
            var output = _generator.Generate("DOCUMENTING").ToArray();

            //Check.That(output.Count()).IsEqualTo(DocumentingTwoWordsAnagram.Count);
            Check.That(output).Contains(DocumentingTwoWordsAnagram);
        }

        [TestMethod]
        public void GivenWordRareWhenGenerateThenOutputIsCorrect()
        {
            var output = _generator.Generate("RARE").OrderBy(o => o).ToList();
            var checkedEx = new[] { "ER AR", "RE AR", "RARE", "REAR" };

            //Check.That(checkedEx.Count()).IsEqualTo(output.Count());
            Check.That(output).Contains(checkedEx);
        }
    }
}