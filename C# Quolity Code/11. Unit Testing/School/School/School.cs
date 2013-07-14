using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolLib
{
    public class School
    {
        private string name;
        private List<Course> courseList;

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Please enter a school name! The filed cannot be null or empty!");
                }
                this.name = value;
            }
        }

        public List<Course> CourseList
        {
            get
            {
                return this.courseList;
            }

            protected set
            {
                this.courseList = value;
            }
        }

        public School(string name)
        {
            this.Name = name;
            this.CourseList = new List<Course>();
        }

        public void AddCourse(Course course)
        {
            //Courses have no ID and the name is not unique, so we cant check anything.
            this.CourseList.Add(course);   
        }

        public void RemoveCourse(Course course)
        {
            if (this.CourseFound(course))
            {
                this.CourseList.Remove(course);
            }
            else
            {
                throw new ArgumentException("Course does not exist.");            
            }
        }

        private bool CourseFound(Course course)
        {
            for (int i = 0; i < this.CourseList.Count; i++)
            {
                if (course == this.CourseList[i])
                {
                    return true;
                }
            }

            return false;
        }

    }
}
