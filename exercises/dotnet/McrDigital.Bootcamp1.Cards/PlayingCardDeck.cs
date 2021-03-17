using System;
using System.Collections.Generic;
using System.Text;

namespace McrDigital.Bootcamp1.Cards
{
    public class PlayingCardDeck
    {

        private List<PlayingCard> deck;

        
        public List<PlayingCard> getDeck(PlayingCard[] cards) {
            
            deck = new List<PlayingCard>();

            //List<PlayingCard> deck = new List<PlayingCard>();

            foreach (PlayingCard card in cards) {
                deck.Add(card);
            }

            return deck;
        }
        
        
        public PlayingCard[] SetCards()
        {
            var deck = new int[52][];
            var result = new PlayingCard[52];
            //var result = new string[52];

            for (var suit = 0; suit < 4; suit++)
            {
                for (var faceValue = 0; faceValue < 13; faceValue++)
                {
                    deck[suit * 13 + faceValue] = new int[] { suit, faceValue };
                }
            }

            int cardNumber = 0;
            string cardValue = "";
            string cardSuit = "";

            foreach (var card in deck)
            {
                PlayingCard playingCard = new PlayingCard();
                cardValue = setCardValue(card[1]);
                cardSuit = setSuitValue(card[0]);

                playingCard.CardValue = cardValue;
                playingCard.CardSuit = cardSuit;
                playingCard.getCard();

                result[cardNumber] = playingCard;
                cardNumber++;
            }

            return result;
        }

        public static string setCardValue(int cardNumber)
        {
            var cardValue = "";
            switch (cardNumber)
            {
                case 0:
                    cardValue = "ace";
                    break;
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    cardValue = (cardNumber + 1).ToString();
                    break;
                case 10:
                    cardValue = "jack";
                    break;
                case 11:
                    cardValue = "queen";
                    break;
                case 12:
                    cardValue = "king";
                    break;
                default: throw new ArgumentException($"Something went wrong {cardNumber} is not a valid faceValue!");
            }

            return cardValue;
        }

        public static string setSuitValue(int cardNumber)
        {
            var cardSuit = string.Empty;
            switch (cardNumber)
            {
                case 0:
                    cardSuit = "clubs";
                    break;
                case 1:
                    cardSuit = "diamonds";
                    break;
                case 2:
                    cardSuit = "hearts";
                    break;
                case 3:
                    cardSuit = "spades";
                    break;
                default: throw new ArgumentException($"Something went wrong {cardNumber} is not a valid suitName!");
            }

            return cardSuit;
        }
    }
}
