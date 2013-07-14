using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameFifteen;

namespace MatrixTaskTest
{
    [TestClass]
    public class CurrentPositionTest
    {
        [TestMethod]
        public void MoveTestSoutheastTest()
        {
            CurrentPosition position = new CurrentPosition(2, 2);
            position.Move(Direction.Southeast);
            int expectedRow = 3;
            int expectedCol = 3;

            int actualRow = position.Row;
            int actualCol = position.Col;

            Assert.AreEqual(expectedRow, actualRow);
            Assert.AreEqual(expectedCol, actualCol);
        }

        [TestMethod]
        public void MoveTestSouthwestTest()
        {
            CurrentPosition position = new CurrentPosition(2, 2);
            position.Move(Direction.Southwest);
            int expectedRow = 3;
            int expectedCol = 1;

            int actualRow = position.Row;
            int actualCol = position.Col;

            Assert.AreEqual(expectedRow, actualRow);
            Assert.AreEqual(expectedCol, actualCol);
        }

        [TestMethod]
        public void MoveTestWestTest()
        {
            CurrentPosition position = new CurrentPosition(2, 2);
            position.Move(Direction.West);
            int expectedRow = 2;
            int expectedCol = 1;

            int actualRow = position.Row;
            int actualCol = position.Col;

            Assert.AreEqual(expectedRow, actualRow);
            Assert.AreEqual(expectedCol, actualCol);
        }

        [TestMethod]
        public void MoveTestNorthwestTest()
        {
            CurrentPosition position = new CurrentPosition(2, 2);
            position.Move(Direction.Northwest);
            int expectedRow = 1;
            int expectedCol = 1;

            int actualRow = position.Row;
            int actualCol = position.Col;

            Assert.AreEqual(expectedRow, actualRow);
            Assert.AreEqual(expectedCol, actualCol);
        }

        [TestMethod]
        public void MoveTestNorthTest()
        {
            CurrentPosition position = new CurrentPosition(2, 2);
            position.Move(Direction.North);
            int expectedRow = 1;
            int expectedCol = 2;

            int actualRow = position.Row;
            int actualCol = position.Col;

            Assert.AreEqual(expectedRow, actualRow);
            Assert.AreEqual(expectedCol, actualCol);
        }

        [TestMethod]
        public void MoveTestNortheastTest()
        {
            CurrentPosition position = new CurrentPosition(2, 2);
            position.Move(Direction.Northeast);
            int expectedRow = 1;
            int expectedCol = 3;

            int actualRow = position.Row;
            int actualCol = position.Col;

            Assert.AreEqual(expectedRow, actualRow);
            Assert.AreEqual(expectedCol, actualCol);
        }

        [TestMethod]
        public void MoveTestEastTest()
        {
            CurrentPosition position = new CurrentPosition(2, 2);
            position.Move(Direction.East);
            int expectedRow = 2;
            int expectedCol = 3;

            int actualRow = position.Row;
            int actualCol = position.Col;

            Assert.AreEqual(expectedRow, actualRow);
            Assert.AreEqual(expectedCol, actualCol);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void MoveTestNone()
        {
            CurrentPosition position = new CurrentPosition(2, 2);
            position.Move(Direction.None);
        }
    }
}
