namespace McrDigital.Bootcamp1.Cards.Tests
{
    using Xunit;
    using McrDigital.Bootcamp1.Cards;
    using System.Collections.Generic;


    public class CardsTest
    {
        [Fact]
        public void ShouldGetDeckInOrderAndReturn52CardsCorrectlyFormatted()
        {
            var deck = new PlayingCardDeck();
            var cards = deck.SetCards();
            var deckInOrder = deck.getDeck(cards);

            List<PlayingCard> expected = new List<PlayingCard>() {
                    new PlayingCard {CardValue = "ace", CardSuit = "clubs" },
                    new PlayingCard {CardValue = "2", CardSuit = "clubs" },
                    new PlayingCard {CardValue = "3", CardSuit = "clubs" },
                    new PlayingCard {CardValue = "4", CardSuit = "clubs" },
                    new PlayingCard {CardValue = "5", CardSuit = "clubs" },
                    new PlayingCard {CardValue = "6", CardSuit = "clubs" },
                    new PlayingCard {CardValue = "7", CardSuit = "clubs" },
                    new PlayingCard {CardValue = "8", CardSuit = "clubs" },
                    new PlayingCard {CardValue = "9", CardSuit = "clubs" },
                    new PlayingCard {CardValue = "10", CardSuit = "clubs" },
                    new PlayingCard {CardValue = "jack", CardSuit = "clubs" },
                    new PlayingCard {CardValue = "queen", CardSuit = "clubs" },
                    new PlayingCard {CardValue = "king", CardSuit = "clubs" },
                    new PlayingCard {CardValue = "ace", CardSuit = "diamonds" },
                    new PlayingCard {CardValue = "2", CardSuit = "diamonds" },
                    new PlayingCard {CardValue = "3", CardSuit = "diamonds" },
                    new PlayingCard {CardValue = "4", CardSuit = "diamonds" },
                    new PlayingCard {CardValue = "5", CardSuit = "diamonds" },
                    new PlayingCard {CardValue = "6", CardSuit = "diamonds" },
                    new PlayingCard {CardValue = "7", CardSuit = "diamonds" },
                    new PlayingCard {CardValue = "8", CardSuit = "diamonds" },
                    new PlayingCard {CardValue = "9", CardSuit = "diamonds" },
                    new PlayingCard {CardValue = "10", CardSuit = "diamonds" },
                    new PlayingCard {CardValue = "jack", CardSuit = "diamonds" },
                    new PlayingCard {CardValue = "queen", CardSuit = "diamonds" },
                    new PlayingCard {CardValue = "king", CardSuit = "diamonds" },
                    new PlayingCard {CardValue = "ace", CardSuit = "hearts" },
                    new PlayingCard {CardValue = "2", CardSuit = "hearts" },
                    new PlayingCard {CardValue = "3", CardSuit = "hearts" },
                    new PlayingCard {CardValue = "4", CardSuit = "hearts" },
                    new PlayingCard {CardValue = "5", CardSuit = "hearts" },
                    new PlayingCard {CardValue = "6", CardSuit = "hearts" },
                    new PlayingCard {CardValue = "7", CardSuit = "hearts" },
                    new PlayingCard {CardValue = "8", CardSuit = "hearts" },
                    new PlayingCard {CardValue = "9", CardSuit = "hearts" },
                    new PlayingCard {CardValue = "10", CardSuit = "hearts" },
                    new PlayingCard {CardValue = "jack", CardSuit = "hearts" },
                    new PlayingCard {CardValue = "queen", CardSuit = "hearts" },
                    new PlayingCard {CardValue = "king", CardSuit = "hearts" },
                    new PlayingCard {CardValue = "ace", CardSuit = "spades" },
                    new PlayingCard {CardValue = "2", CardSuit = "spades" },
                    new PlayingCard {CardValue = "3", CardSuit = "spades" },
                    new PlayingCard {CardValue = "4", CardSuit = "spades" },
                    new PlayingCard {CardValue = "5", CardSuit = "spades" },
                    new PlayingCard {CardValue = "6", CardSuit = "spades" },
                    new PlayingCard {CardValue = "7", CardSuit = "spades" },
                    new PlayingCard {CardValue = "8", CardSuit = "spades" },
                    new PlayingCard {CardValue = "9", CardSuit = "spades" },
                    new PlayingCard {CardValue = "10", CardSuit = "spades" },
                    new PlayingCard {CardValue = "jack", CardSuit = "spades" },
                    new PlayingCard {CardValue = "queen", CardSuit = "spades" },
                    new PlayingCard {CardValue = "king", CardSuit = "spades" }
                };
            Assert.Equal(expected, deckInOrder);
        }
    }
}