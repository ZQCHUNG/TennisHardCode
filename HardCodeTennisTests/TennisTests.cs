using HardCodeTennis;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HardCodeTennisTests
{
    [TestClass]
    public class TennisTests
    {
        private readonly Tennis _tennis = new Tennis();

        [TestMethod]
        public void love_all()
        {
            ScoreShouldBe("love all");
        }

        [TestMethod]
        public void fifteen_love()
        {
            GivenFirstPlayerScore(1);
            ScoreShouldBe("fifteen love");
        }


        [TestMethod]
        public void thirty_love()
        {
            GivenFirstPlayerScore(2);
            ScoreShouldBe("thirty love");
        }

        [TestMethod]
        public void forty_love()
        {
            GivenFirstPlayerScore(3);
            ScoreShouldBe("forty love");
        }

        [TestMethod]
        public void love_fifteen()
        {
            GivenSecondPlayerScore(1);
            ScoreShouldBe("love fifteen");
        }


        [TestMethod]
        public void love_thirty()
        {
            GivenSecondPlayerScore(2);
            ScoreShouldBe("love thirty");
        }


        [TestMethod]
        public void love_forty()
        {
            GivenSecondPlayerScore(3);
            ScoreShouldBe("love forty");
        }


        [TestMethod]
        public void fifteen_all()
        {
            GivenFirstPlayerScore(1);
            GivenSecondPlayerScore(1);
            ScoreShouldBe("fifteen all");
        }


        [TestMethod]
        public void thirty_all()
        {
            GivenFirstPlayerScore(2);
            GivenSecondPlayerScore(2);
            ScoreShouldBe("thirty all");
        }


        [TestMethod]
        public void deuce_3_3()
        {
            GivenDeuce();
            ScoreShouldBe("deuce");
        }


        [TestMethod]
        public void deuce_4_4()
        {
            GivenDeuce();
            GivenFirstPlayerScore(1);
            GivenSecondPlayerScore(1);
            ScoreShouldBe("deuce");
        }

        [TestMethod]
        public void first_player_adv()
        {
            GivenDeuce();
            GivenFirstPlayerScore(1);
            ScoreShouldBe("Sam adv");
        }

        [TestMethod]
        public void first_player_win()
        {
            GivenDeuce();
            GivenFirstPlayerScore(2);
            ScoreShouldBe("Sam win");
        }

        [TestMethod]
        public void second_player_adv()
        {
            GivenDeuce();
            GivenSecondPlayerScore(1);
            ScoreShouldBe("Joe adv");
        }


        [TestMethod]
        public void second_player_win()
        {
            GivenDeuce();
            GivenSecondPlayerScore(2);
            ScoreShouldBe("Joe win");
        }


        private void GivenDeuce()
        {
            GivenFirstPlayerScore(3);
            GivenSecondPlayerScore(3);
        }

        private void ScoreShouldBe(string expected)
        {
            var actual = _tennis.Score();

            Assert.AreEqual(expected, actual);
        }

        private void GivenSecondPlayerScore(int times)
        {
            for (var i = 0; i < times; i++) _tennis.SecondPlayerScore();
        }

        private void GivenFirstPlayerScore(int times)
        {
            for (var i = 0; i < times; i++) _tennis.FirstPlayerScore();
        }
    }
}