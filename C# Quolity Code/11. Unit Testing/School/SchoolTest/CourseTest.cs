using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolLib;
namespace SchoolTest
{
    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        public void TestCourseConstructorName()
        {
            string name = "ASD123!@#$%^&*()";
            Course course = new Course(name);
            Assert.AreEqual(course.Name, name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TeswCourseConstructorEmptyName()
        {
            string name = string.Empty;
            Course course = new Course(name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestCourseConstructorNullName()
        {
            string name = null;
            Course course = new Course(name);
        }

        [TestMethod]
        public void TestJoinStudentName()
        {
            Student student = new Student("Ivaylo", 15000);
            Course course = new Course("C#");
            course.Join(student);
            Assert.AreEqual(student.Name, course.StudentsList[0].Name);
        }

        [TestMethod]
        public void TestJoinStudentId()
        {
            Student student = new Student("Ivaylo", 15000);
            Course course = new Course("C#");
            course.Join(student);
            Assert.AreEqual(student.Id, course.StudentsList[0].Id);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestJoinSameStudents()
        {
            Student student = new Student("Ivaylo", 15000);
            Course course = new Course("C#");
            course.Join(student);
            course.Join(student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestJoinMaxStudents()
        {
            int studentId = 15000;
            Course course = new Course("C#");
            for (int i = 0; i <= Course.MaxNumberOfStudents + 1; i++)
            {
                course.Join(new Student("Ivaylo", studentId));
                studentId++;
            }
        }

        [TestMethod]
        public void TestLeaveStudent()
        {
            Student student = new Student("Ivaylo", 15000);
            Course course = new Course("C#");
            course.Join(student);
            course.Leave(student);
            Assert.IsTrue(course.StudentsList.Count == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestLeaveWithoutJoin()
        {

            Student student = new Student("Ivaylo", 15000);
            Course course = new Course("C#");
            course.Leave(student);
        }
    }
}
