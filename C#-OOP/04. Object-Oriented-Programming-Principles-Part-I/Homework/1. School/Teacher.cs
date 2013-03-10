﻿using System.Collections.Generic;

namespace School
{
    class Teacher : Human
    {
        private List<Discipline> disciplines;

        public List<Discipline> Disciplines
        {
            get
            {
                return this.disciplines;
            }
            set
            {
                this.disciplines = value;
            }
        }


        public Teacher(string name, List<Discipline> disciplines)
            :base(name)
        {
            this.Disciplines = disciplines;
        }
    }
}
