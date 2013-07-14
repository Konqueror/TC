using System;

namespace Poker
{
    public class Card : ICard, IComparable
    {
        public CardFace Face { get; private set; }
        public CardSuit Suit { get; private set; }

        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public int CompareTo(object otherObject)
        {
            if (otherObject is Card)
            {
                Card compareCard = (Card)otherObject;
                if (this.Face < compareCard.Face)
                {
                    return -1;
                }
                else if (this.Face > compareCard.Face)
                {
                    return 1;
                }
                return 0;
            }

            throw new ArgumentException("");
        }

        public override string ToString()
        {
            string faceStr;
            if ((int)this.Face <= 10)
            {
                faceStr = ((int)this.Face).ToString();
            }
            else
            {
                string faceName = Face.ToString();
                char faceLetter = faceName[0];
                faceStr = faceLetter.ToString();
            }

            char suit;
            switch (this.Suit)
            {
                case CardSuit.Clubs:
                    suit = '♣';
                    break;
                case CardSuit.Diamonds:
                    suit = '♦';
                    break;
                case CardSuit.Hearts:
                    suit = '♥';
                    break;
                case CardSuit.Spades:
                    suit = '♠';
                    break;
                default:
                    throw new InvalidOperationException("Invalid Suit: " + this.Suit);
            }

            return faceStr + suit;
        }
    }
}
