using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;

namespace StudentClass
{

    class StudentClass
    {
       static void Main(string[] args)
        {
            Student Stud1 = new Student("Derek Hecker", 123456789);
            Stud1.Major = "Cyber Operations";
            Stud1.printStudentInfo();
            Stud1.PrivacyChoice = true;
            Stud1.printStudentInfo();

        }
    }
}
