using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Methods
{
    class Student
    {
        public string name;
        public string major;
        public double gpa;

        public Student(string aName, string aMajor, double aGpa)
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;

        }

        //creating the object method below the constructor, objectmethod is below this comment
        //basically if the gpa is greater than or equal to 2.5 the members of the student class will return value true
        //otherwise they will return value false
        public bool HasHonors()
        {
            if (gpa >= 2.5)
            {
                return true;
            }
            return false;
        }
    }
}
