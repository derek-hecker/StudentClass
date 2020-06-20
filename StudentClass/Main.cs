using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;

namespace StudentClass
{

    public class StudentClass
    {
      
       static void Main(string[] args)
        {
            
            //  Stud1.printStudentInfo();
            // Student Stud1 = new Student(123456788, "", "Cyber Operations", "@trojans.dsu.edu", "USA","PA", "Spring 2018", "Spring 2020","999-999-9999", "Street Address", false);

            
            //Student 1
            Student Stud1 = new Student(123456789, "Derek Hecker", "Cyber Operations", "derek.hecker@trojans.dsu.edu", "USA", "PA", "Spring 2018", "Spring 2020", "999-999-9999", "Street Address", true);
            Stud1.printStudentInfo();

            //Student 2
            Student Stud2 = new Student("Donavon", 654987);
            Stud2.EmailAddress = "Donovan.McNabb@trojans.dsu.edu";
            Stud2.Major = "Computer Science";
            Stud2.Country = "USA";
            Stud2.GradDate = "Never";
            Stud2.StartDate = "Sometime";
            Stud2.PhoneNumber = "999-999-9999";
            Stud2.MailingAddress = "Somewhere close by";
            Stud2.printStudentInfo();

            //Student 3
            Student Stud3 = new Student("Brian", 789456321);
            Stud3.EmailAddress = "Brian.Dawkins@trojans.dsu.edu";
            Stud3.Major = "Computer Science";
            Stud3.Country = "USA";
            Stud3.GradDate = "Never";
            Stud3.StartDate = "Sometime";
            Stud3.PhoneNumber = "999-999-9999";
            Stud3.MailingAddress = "Somewhere close by";
            Stud3.printStudentInfo();
            //Student 4
            Student Stud4 = new Student("Lito", 654987);
            Stud4.EmailAddress = "Lito.Sheppard@trojans.dsu.edu";
            Stud4.Major = "Computer Science";
            Stud4.Country = "USA";
            Stud4.GradDate = "Never";
            Stud4.StartDate = "Sometime";
            Stud4.PhoneNumber = "999-999-9999";
            Stud4.MailingAddress = "Somewhere close by";
            Stud4.printStudentInfo();
            //Student 5
            Student Stud5 = new Student("Nick", 123698547);
            Stud5.EmailAddress = "Nick.Foles@trojans.dsu.edu";
            Stud5.Major = "Computer Science";
            Stud5.Country = "USA";
            Stud5.GradDate = "Never";
            Stud5.StartDate = "Sometime";
            Stud5.PhoneNumber = "999-999-9999";
            Stud5.MailingAddress = "Somewhere close by";
            Stud5.printStudentInfo();
            //Student 6
            Student Stud6 = new Student("Trey", 456321987);
            Stud6.EmailAddress = "Trey.Burton@trojans.dsu.edu";
            Stud6.Major = "Computer Science";
            Stud6.Country = "USA";
            Stud6.GradDate = "Never";
            Stud6.StartDate = "Sometime";
            Stud6.PhoneNumber = "999-999-9999";
            Stud6.MailingAddress = "Somewhere close by";
            Stud6.printStudentInfo();
            //Student 7
            Student Stud7 = new Student("Carson", 11);
            Stud7.EmailAddress = "Carson.Wentz@trojans.dsu.edu";
            Stud7.Major = "Computer Science";
            Stud7.Country = "USA";
            Stud7.GradDate = "Never";
            Stud7.StartDate = "Sometime";
            Stud7.PhoneNumber = "999-999-9999";
            Stud7.MailingAddress = "Somewhere close by";
            Stud7.printStudentInfo();
            //Student 8
            Student Stud8 = new Student("Miles", 888988);
            Stud8.EmailAddress = "Miles.Sanders@trojans.dsu.edu";
            Stud8.Major = "Computer Science";
            Stud8.Country = "USA";
            Stud8.GradDate = "Never";
            Stud8.StartDate = "Sometime";
            Stud8.PhoneNumber = "999-999-9999";
            Stud8.MailingAddress = "Somewhere close by";
            Stud8.printStudentInfo();
            //Student 9
            Student Stud9 = new Student("Alshon", 999999);
            Stud9.EmailAddress = "Alshon.Jeffrey@trojans.dsu.edu";
            Stud9.Major = "Computer Science";
            Stud9.Country = "USA";
            Stud9.GradDate = "Never";
            Stud9.StartDate = "Sometime";
            Stud9.PhoneNumber = "999-999-9999";
            Stud9.MailingAddress = "Somewhere close by";
            Stud9.printStudentInfo();
            //Student 10
            Student Stud10 = new Student("Brandon", 101010101010);
            Stud10.EmailAddress = "Brandon.Graham@trojans.dsu.edu";
            Stud10.Major = "Computer Science";
            Stud10.Country = "USA";
            Stud10.GradDate = "Never";
            Stud10.StartDate = "Sometime";
            Stud10.PhoneNumber = "101010-101010-10101010";
            Stud10.MailingAddress = "Somewhere close by";
            Stud10.printStudentInfo();
            //Output change logs for all students
            Stud1.printLog();
            Stud2.printLog();
            Stud3.printLog();
            Stud4.printLog();
            Stud5.printLog();
            Stud6.printLog();
            Stud7.printLog();
            Stud8.printLog();
            Stud9.printLog();
            Stud10.printLog();

        }
    }
}
