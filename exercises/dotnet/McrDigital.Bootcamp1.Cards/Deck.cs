using System;
using System.Collections.Generic;
using System.Text;

namespace McrDigital.Bootcamp1.Cards
{
    class Deck
    {

        public static string getSuit(int card) { 
        var suitName = string.Empty;
            switch (card)
            {
                case 0:
                    suitName = "clubs";
                    break;
                case 1:
                    suitName = "diamonds";
                    break;
                case 2:
                    suitName = "hearts";
                    break;
                case 3:
                    suitName = "spades";
                    break;
                default: throw new ArgumentException($"Something went wrong {card} is not a valid suitName!");
            }

            return suitName;
        }

        public static string getCardValue(int card) {
            
            var faceValueName = "";
            switch (card)
            {
                case 0:
                    faceValueName = "ace";
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
                    faceValueName = (card + 1).ToString();
                    break;
                case 10:
                    faceValueName = "jack";
                    break;
                case 11:
                    faceValueName = "queen";
                    break;
                case 12:
                    faceValueName = "king";
                    break;
                default: throw new ArgumentException($"Something went wrong {card} is not a valid faceValue!");
            }

            return faceValueName;
        }
    }
}
