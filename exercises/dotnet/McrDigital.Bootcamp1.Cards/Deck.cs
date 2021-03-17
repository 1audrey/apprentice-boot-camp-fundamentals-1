using System;
using System.Collections.Generic;
using System.Text;

namespace McrDigital.Bootcamp1.Cards
{
    public class Deck
    {
        public void Shuffle(List<Object> cards)
        {
            cards.KnuthShuffle();
        }
    }
}
