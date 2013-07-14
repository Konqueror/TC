using System;
using System.Collections.Generic;
using System.Text;

namespace Poker
{
    public class Hand : IHand
    {
        public List<ICard> Cards { get; private set; }

        public Hand(List<ICard> cards)
        {
            this.Cards = cards;
        }

        public override string ToString()
        {
            StringBuilder handBuilder = new StringBuilder();
            foreach (var card in this.Cards)
            {
                handBuilder.Append(card.ToString());
            }

            return handBuilder.ToString();
        }

        public void Sort()
        {
            Cards.Sort();
        }
    }
}
