using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerTest
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void TestAllClubsToStrineg()
        {
            string[] clubs = { "2♣", "3♣", "4♣", "5♣", "6♣", "7♣", "8♣", "9♣", "10♣", "J♣", "Q♣", "K♣", "A♣" };
            for (int i = 0; i < clubs.Length; i++)
            {
                Card card = new Card((CardFace)(i + 2), CardSuit.Clubs);
                string actual = card.ToString();
                Assert.AreEqual(clubs[i], actual);
            }
        }

        [TestMethod]
        public void TestAllDiamondsToStrineg()
        {
            string[] clubs = { "2♦", "3♦", "4♦", "5♦", "6♦", "7♦", "8♦", "9♦", "10♦", "J♦", "Q♦", "K♦", "A♦" };
            for (int i = 0; i < clubs.Length; i++)
            {
                Card card = new Card((CardFace)(i + 2), CardSuit.Diamonds);
                string actual = card.ToString();
                Assert.AreEqual(clubs[i], actual);
            }
        }

        [TestMethod]
        public void TestAllHeartsToStrineg()
        {
            string[] clubs = { "2♥", "3♥", "4♥", "5♥", "6♥", "7♥", "8♥", "9♥", "10♥", "J♥", "Q♥", "K♥", "A♥" };
            for (int i = 0; i < clubs.Length; i++)
            {
                Card card = new Card((CardFace)(i + 2), CardSuit.Hearts);
                string actual = card.ToString();
                Assert.AreEqual(clubs[i], actual);
            }
        }

        [TestMethod]
        public void TestAllSpadesToStrineg()
        {
            string[] clubs = { "2♠", "3♠", "4♠", "5♠", "6♠", "7♠", "8♠", "9♠", "10♠", "J♠", "Q♠", "K♠", "A♠" };
            for (int i = 0; i < clubs.Length; i++)
            {
                Card card = new Card((CardFace)(i + 2), CardSuit.Spades);
                string actual = card.ToString();
                Assert.AreEqual(clubs[i], actual);
            }
        }


        [TestMethod]
        public void TestCardCompearStrongerToWeaker()
        {
            Card strongCard = new Card(CardFace.King, CardSuit.Spades);
            Card weakCard = new Card(CardFace.Seven, CardSuit.Spades);
            int actual = strongCard.CompareTo(weakCard);
            int expect = 1;
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestCardCompearWeakerToStronger()
        {
            Card strongCard = new Card(CardFace.King, CardSuit.Spades);
            Card weakCard = new Card(CardFace.Seven, CardSuit.Spades);
            int actual = weakCard.CompareTo(strongCard);
            int expect = -1;
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCardCompearInvalidArgumentExeption()
        {
            Card card = new Card(CardFace.King, CardSuit.Spades);
            string aceAsString = "Ace";
            int result = card.CompareTo(aceAsString);
        }
    }
}
