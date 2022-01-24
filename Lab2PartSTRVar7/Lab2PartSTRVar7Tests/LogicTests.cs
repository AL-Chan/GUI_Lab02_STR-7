using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Lab2PartSTRVar7.Form1;

namespace Lab2PartSTRVar7.Tests
{
    [TestClass()]
    public class LogicTests
    {

        [TestMethod()]
        public void OdinPovtor()
        {
            string sentence = "Мама!мыла @#аквариу!м";
            Logic Logic= new Logic();
            int dub = Logic.Dub(sentence);
            var Itog = Logic.ProcessGoing(dub);
             Assert.AreEqual("Количество повторяющихся пар букв в предложении: 1", Itog);
        }

        [TestMethod()]
        public void TriPovtora()
        {
            string sentence = "зооорганизация %:ялюблюживотных";
            Logic Logic = new Logic();
            int dub = Logic.Dub(sentence);
            var Itog = Logic.ProcessGoing(dub);
            Assert.AreEqual("Количество повторяющихся пар букв в предложении: 3", Itog);
        }

        [TestMethod()]
        public void NetPovtora()
        {
            string sentence = "Воин Цусимы";
            Logic Logic = new Logic();
            int dub = Logic.Dub(sentence);
            var Itog = Logic.ProcessGoing(dub);
            Assert.AreEqual("В этом предложении нет повторяющихся пар букв", Itog);
        }

    }
}

