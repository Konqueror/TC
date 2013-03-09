using System;

namespace Version
{
    //apply only for structs, classes, interfaces, enums and methods
    [AttributeUsage(AttributeTargets.Struct |
                     AttributeTargets.Class |
                     AttributeTargets.Interface |
                     AttributeTargets.Enum |
                     AttributeTargets.Method)]

    class Version : System.Attribute
    {
        private int major = 0;
        private int minor = 0;

        public int Major
        {
            get
            {
                return this.major;
            }
            set
            {
                this.major = value;
            }
        }

        public int Minor
        {
            get
            {
                return this.minor;
            }
            set
            {
                this.minor = value;
            }
        }
        // Constructor
        public Version(string version)
        {
            string[] splited = version.Split('.');

            this.Major = int.Parse(splited[0]);
            this.Minor = int.Parse(splited[1]);
        }

        public override string ToString()
        {
            return this.major + "." + this.minor;
        }

    }
}
