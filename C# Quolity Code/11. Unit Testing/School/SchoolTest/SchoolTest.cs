using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolLib;

namespace SchoolTest
{
    [TestClass]
    public class SchoolTest
    {
        [TestMethod]
        public void TestSchoolConstructorName()
        {
            string name = "FMI";
            School school = new School(name);
            Assert.AreEqual(school.Name, name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestSchoolConstructorEmptyName()
        {
            string name = string.Empty;
            School school = new School(name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestSchoolConstructorNullName()
        {
            string name = null;
            School school = new School(name);
        }

        [TestMethod]
        public void TestAddCourseName()
        {
            Course course = new Course("C#");
            School school = new School("FMI");
            school.AddCourse(course);
            Assert.AreEqual(course.Name, school.CourseList[0].Name);
        }


        [TestMethod]
        public void TestRemoveCourse()
        {
            Course course = new Course("C#");
            School school = new School("FMI");
            school.AddCourse(course);
            school.RemoveCourse(course);
            Assert.IsTrue(school.CourseList.Count == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRemoveNotAddedCourse()
        {
            Course course = new Course("C#");
            School school = new School("FMI");
            school.RemoveCourse(course);
        }


    }
}
