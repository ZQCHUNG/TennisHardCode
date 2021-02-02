
namespace HardCodeTennis
{
    public class Tennis
    {
        private int _firstPlayerScoreTimes;
        private int _secondPlayerScoreTimes;

        public string Score()
        {
            if (_firstPlayerScoreTimes == 0 && _secondPlayerScoreTimes == 0)
            {
                return "love all";
            }
            if (_firstPlayerScoreTimes == 1 && _secondPlayerScoreTimes == 0)
            {
                return "fifteen love";
            }
            if (_firstPlayerScoreTimes == 2 && _secondPlayerScoreTimes == 0)
            {
                return "thirty love";
            }
            if (_firstPlayerScoreTimes == 3 && _secondPlayerScoreTimes == 0)
            {
                return "forty love";
            }
            if (_firstPlayerScoreTimes == 0 && _secondPlayerScoreTimes == 1)
            {
                return "love fifteen";
            }
            if (_firstPlayerScoreTimes == 0 && _secondPlayerScoreTimes == 2)
            {
                return "love thirty";
            }
            if (_firstPlayerScoreTimes == 0 && _secondPlayerScoreTimes == 3)
            {
                return "love forty";
            }
            if (_firstPlayerScoreTimes == 1 && _secondPlayerScoreTimes == 1)
            {
                return "fifteen all";
            }
            if (_firstPlayerScoreTimes == 2 && _secondPlayerScoreTimes == 2)
            {
                return "thirty all";
            }
            if (_firstPlayerScoreTimes == 3 && _secondPlayerScoreTimes == 3)
            {
                return "deuce";
            }
            if (_firstPlayerScoreTimes == 4 && _secondPlayerScoreTimes == 4)
            {
                return "deuce";
            }
            if (_firstPlayerScoreTimes == 4 && _secondPlayerScoreTimes == 3)
            {
                return "Sam adv";
            }
            if (_firstPlayerScoreTimes == 3 && _secondPlayerScoreTimes == 4)
            {
                return "Joe adv";
            }
            if (_firstPlayerScoreTimes == 5 && _secondPlayerScoreTimes == 3)
            {
                return "Sam win";
            }
            if (_firstPlayerScoreTimes == 3 && _secondPlayerScoreTimes == 5)
            {
                return "Joe win";
            }

            return null;
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScoreTimes++;
        }

        public void SecondPlayerScore()
        {
            _secondPlayerScoreTimes++;
        }
    }
}
