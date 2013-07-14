using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;
using System.Collections.Generic;

namespace PokerTest
{
    [TestClass]
    public class PokerHandCheckerTest
    {
        [TestMethod]
        public void TestIsValidHandTrue()
        {
            Hand hand = new Hand(new List<ICard>{
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds)
            });

            bool expected = true;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsValidHand(hand);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsValidHandFalse()
        {
            Hand hand = new Hand(new List<ICard>{
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Diamonds)
            });

            bool expected = false;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsValidHand(hand);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsStraightFlushTrue()
        {
            Hand hand = new Hand(new List<ICard>{
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Diamonds),
            });

            bool expected = true;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsStraightFlush(hand);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsStraightFlushFalse()
        {
            Hand hand = new Hand(new List<ICard>{
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Diamonds),
            });

            bool expected = false;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsStraightFlush(hand);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsFourOfAKindTrue()
        {
            Hand hand = new Hand(new List<ICard>{
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Diamonds),
            });

            bool expected = true;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsFourOfAKind(hand);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsFourOfAKindFalse()
        {
            Hand hand = new Hand(new List<ICard>{
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Diamonds),
            });

            bool expected = false;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsFourOfAKind(hand);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsFlushTrue()
        {
            Hand hand = new Hand(new List<ICard>{
                new Card(CardFace.Four, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Diamonds),
            });

            bool expected = true;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsFlush(hand);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsFlushFalse()
        {
            Hand hand = new Hand(new List<ICard>{
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Diamonds),
            });

            bool expected = false;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsFlush(hand);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsStraightTrue()
        {
            Hand hand = new Hand(new List<ICard>{
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Diamonds),
            });

            bool expected = true;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsStraight(hand);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsStraightFalse()
        {
            Hand hand = new Hand(new List<ICard>{
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Diamonds),
            });

            bool expected = false;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsStraight(hand);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsThreeOfAKindTrue()
        {
            Hand hand = new Hand(new List<ICard>{
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Diamonds),
            });

            bool expected = true;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsThreeOfAKind(hand);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsThreeOfAKindFalse()
        {
            Hand hand = new Hand(new List<ICard>{
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Diamonds),
            });

            bool expected = false;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsThreeOfAKind(hand);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsTwoPairTrue()
        {
            Hand hand = new Hand(new List<ICard>{
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Diamonds),
            });

            bool expected = true;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsTwoPair(hand);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsTwoPairFalse()
        {
            Hand hand = new Hand(new List<ICard>{
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Diamonds),
            });

            bool expected = false;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsTwoPair(hand);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestScoreFlush()
        {
            Hand hand = new Hand(new List<ICard>{
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Clubs),
            });

            Hands expected = Hands.Flush;
            PokerHandsChecker checker = new PokerHandsChecker();
            Hands actual = checker.Score(hand);

            Assert.AreEqual(expected, actual);
            //TODO: Test all cases
        }

        [TestMethod]
        public void TestCompareHandsFalse()
        {
            Hand flush = new Hand(new List<ICard>{
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Clubs),
            });

            Hand straight = new Hand(new List<ICard>{
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs),
            });
            int expected = -1;
            PokerHandsChecker checker = new PokerHandsChecker();
            int actual = checker.CompareHands(flush, straight);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCompareHandsTrue()
        {
            Hand flush = new Hand(new List<ICard>{
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Clubs),
            });

            Hand straight = new Hand(new List<ICard>{
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs),
            });
            int expected = 1;
            PokerHandsChecker checker = new PokerHandsChecker();
            int actual = checker.CompareHands(straight, flush);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCompareHandsEuals()
        {
            Hand flush = new Hand(new List<ICard>{
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Clubs),
            });

            int expected = 0;
            PokerHandsChecker checker = new PokerHandsChecker();
            int actual = checker.CompareHands(flush, flush);

            Assert.AreEqual(expected, actual);
        }
    }
}
