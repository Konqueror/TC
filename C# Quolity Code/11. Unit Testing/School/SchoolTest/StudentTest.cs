using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolLib;

namespace SchoolTest
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void TestStudentConstructorName()
        {
            string name = "Lil !@#$%^&*() Sha";
            int id = 15000;
            Student student = new Student(name, id);
            Assert.AreEqual(student.Name, name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestStudentConstructorNullName()
        {
            string name = null;
            int id = 15000;
            Student student = new Student(name, id);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestStudentConstructorEmptyName()
        {
            string name = string.Empty;
            int id = 15000;
            Student student = new Student(name, id);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestStudentConstructorZeroId()
        {
            string name = "Ivaylo";
            int id = 0;
            Student student = new Student(name, id);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestStudentConstructorOutOfRange()
        {
            string name = "Ivaylo";
            int id = 100000;
            Student student = new Student(name, id);
            Assert.AreEqual(id, student.Id);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestStudentConstructorNegativeId()
        {
            string name = "Ivaylo";
            int id = -5;
            Student student = new Student(name, id);
        }

    }
}
