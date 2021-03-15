namespace McrDigital.Bootcamp1.Cards
{
    using System;

    public class Cards
    {
        static void Main(string[] args)
        {
            var encapsulation = new Cards();
            var deckInOrder = encapsulation.GetCards();
            foreach (var card in deckInOrder)
            {
                Console.WriteLine(card);
            }
        }

        public string[] GetCards()
        {
            var result = new String[52];
            var deck = new int[52][];

            for (var suit = 0; suit < 4; suit++)
            {
                for (var faceValue = 0; faceValue < 13; faceValue++)
                {
                    deck[suit * 13 + faceValue] = new int[] {suit, faceValue};
                }
            }

            var cardNumber = 0;
            foreach (var card in deck)
            {
                var faceValueName = Deck.getCardValue(card[1]);
                var suitName = Deck.getSuit(card[0]);

                result[cardNumber] = $"{faceValueName} of {suitName}";
                cardNumber++;
            }

            return result;
        }
    }
}