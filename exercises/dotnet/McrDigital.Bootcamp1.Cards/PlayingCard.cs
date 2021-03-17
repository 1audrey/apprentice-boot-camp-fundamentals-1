using System;
using System.Collections.Generic;
using System.Text;

namespace McrDigital.Bootcamp1.Cards
{
    public class PlayingCard
    {
        private string _cardValue;
        private string _cardSuit;

        public string CardValue
        {
            get { return _cardValue; }
            set { _cardValue = value; }
        }

        public string CardSuit
        {
            get { return _cardSuit; }
            set { _cardSuit = value; }
        }
    }
}
