using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;
using System.Collections.Generic;

namespace PokerTest
{
    [TestClass]
    public class HandTests
    {
        [TestMethod]
        public void TestHandToString()
        {
            Hand hand = new Hand(new List<ICard>{
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds)
            });

            string expected = "10♦J♥4♠2♣A♦";
            string actual = hand.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestHandSort()
        {
            Hand hand = new Hand(new List<ICard>{
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds)
            });
            hand.Sort();

            string expected = "2♣4♠10♦J♥A♦";
            string actual = hand.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}
