using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameFifteen;
namespace MatrixTaskTest
{
    [TestClass]
    public class FieldTest
    {
        [TestMethod]
        public void FieldConstructorTest()
        {
            Field field = new Field(5);

            int expecte = 5;
            int actual = field.Matrix.GetLength(1);

            Assert.AreEqual(expecte, actual);
        }

        [TestMethod]
        public void FieldAllCellsCountTest()
        {
            Field field = new Field(5);

            int expected = 25;
            int actual = field.AllCellsCount;

            Assert.AreEqual(expected, actual);
        }
    }
}
