namespace McrDigital.Bootcamp1.Cards
{
    using System;

    public class CheckCardsDeck
    {
        static void Main(string[] args)
        {
            var deck = new PlayingCardDeck();
            var deckInOrder = deck.SetCards();
            foreach (var card in deckInOrder)
            {
                Console.WriteLine(card);
            }
        }
    }
}