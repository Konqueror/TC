using System;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            if (hand.Cards.Count == 5)
            {
                return true;
            }
            return false;
        }

        public bool IsStraightFlush(IHand hand)
        {
            if (IsStraight(hand) && IsFlush(hand))
            {
                return true;
            }
            return false;
        }

        public bool IsFourOfAKind(IHand hand)
        {
            hand.Sort();
            if (AllAreEqual(hand.Cards[0].Face, hand.Cards[1].Face, hand.Cards[2].Face, hand.Cards[3].Face) || 
                AllAreEqual(hand.Cards[1].Face, hand.Cards[2].Face, hand.Cards[3].Face, hand.Cards[4].Face))
            {
                return true;
            }

            return false;
        }

        public bool IsFullHouse(IHand hand)
        {
            hand.Sort();
            if ((hand.Cards[0].Face == hand.Cards[1].Face && AllAreEqual(hand.Cards[2].Face, hand.Cards[3].Face, hand.Cards[4].Face))
                || (AllAreEqual(hand.Cards[0].Face, hand.Cards[1].Face, hand.Cards[2].Face) && hand.Cards[3].Face == hand.Cards[4].Face))
            {
                return true;
            }

		    return false;
        }

        public bool IsFlush(IHand hand)
        {
            hand.Sort();
            if (hand.Cards[0].Suit == hand.Cards[1].Suit 
            && hand.Cards[1].Suit == hand.Cards[2].Suit 
            && hand.Cards[2].Suit == hand.Cards[3].Suit
            && hand.Cards[2].Suit == hand.Cards[4].Suit)
            {
                return true;
            }
            return false;
        }

        public bool IsStraight(IHand hand)
        {
            hand.Sort();
            if (AllAreEqual(hand.Cards[0].Face, hand.Cards[1].Face - 1, hand.Cards[2].Face - 2, hand.Cards[3].Face - 3, hand.Cards[4].Face - 4))
            {
                return true;
            }
            return false;
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            hand.Sort();
            if (AllAreEqual(hand.Cards[0].Face, hand.Cards[1].Face, hand.Cards[2].Face)
                || AllAreEqual(hand.Cards[1].Face, hand.Cards[2].Face, hand.Cards[3].Face)
                || AllAreEqual(hand.Cards[2].Face, hand.Cards[3].Face, hand.Cards[4].Face))
            {
                return true;
            }

            return false;
        }

        public bool IsTwoPair(IHand hand)
        {
            hand.Sort();
            if (hand.Cards[0].Face == hand.Cards[1].Face && hand.Cards[2].Face == hand.Cards[3].Face)
            {
                return true;
            }
            if (hand.Cards[0].Face == hand.Cards[1].Face && hand.Cards[3].Face == hand.Cards[4].Face)
            {
                return true;
            }
            if (hand.Cards[1].Face == hand.Cards[2].Face && hand.Cards[3].Face == hand.Cards[4].Face)
            {
                return true;
            }
            return false;
        }

        public bool IsOnePair(IHand hand)
        {
            hand.Sort();
            if (hand.Cards[0].Face == hand.Cards[1].Face ||
                hand.Cards[1].Face == hand.Cards[2].Face ||
                hand.Cards[2].Face == hand.Cards[3].Face ||
                hand.Cards[3].Face == hand.Cards[4].Face)

            {
                return true;
            }
            return false;
        }

        public bool IsHighCard(IHand hand)
        {
            //TODO: Remove it, it is useless
            return true;
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            if ((int)Score(firstHand) > (int)Score(secondHand))
            {
                return 1;
            }
            else if ((int)Score(firstHand) < (int)Score(secondHand))
            {
                return -1;
            }

            return 0;
        }

        public Hands Score(IHand hand)
        {
            //TODO: Refacture with swich case
            if (this.IsStraightFlush(hand))
            {
                return Hands.StraightFlush;
            }
            else if (this.IsFourOfAKind(hand))
            {
                return Hands.FourOfAKind;
            }
            else if (this.IsFullHouse(hand))
            {
                return Hands.FullHouse;
            }
            else if (this.IsFlush(hand))
            {
                return Hands.Flush;
            }
            else if (this.IsStraight(hand))
            {
                return Hands.Straight;
            }
            else if (this.IsThreeOfAKind(hand))
            {
                return Hands.ThreeOfAKind;
            }
            else if (this.IsTwoPair(hand))
            {
                return Hands.TwoPair;
            }
            return Hands.HighCard;
        }

        private static bool AllAreEqual(params CardFace[] args)
        {
            if (args != null && args.Length > 1)
            {
                for (int i = 1; i < args.Length; i++)
                {
                    if (args[i] != args[i - 1]) return false;
                }
            }

            return true;
        } 
    }
}
