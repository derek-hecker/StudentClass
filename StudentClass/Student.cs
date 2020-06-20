using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;


namespace StudentClass
{
    class Student
    {
        //Constructors x2
        //Constructor with two required fields. 
        public Student(string Name, double studentID)
        {
            p_Name = Name; //getter setter done
            p_StudentID = studentID; //getter setter done
            p_Major = ""; //gs done
            p_EmailAddress = ""; //gs done
            p_Country = ""; //gs done
            p_StartDate = ""; //gs done
            p_GradDate = ""; //gs done
            p_State = ""; //gs done
            p_PhoneNumber = ""; //gs done
            p_MailingAddress = "";
            p_PrivacyChoice = false;
            //log.Add(new Logs() { changes = "User has been created with name: " + p_Name });
        }
        //Fully Parameterized Constructor
        public Student(double studentID, string Name, string Major, string email, string country, string state, string start, string grad, string phone, string mailing, bool choice)
        {
            p_Name = Name;
            p_StudentID = studentID;
            p_Major = Major;
            p_EmailAddress = email;
            p_Country = country;
            p_StartDate = start;
            p_GradDate = grad;
            p_State = state;
            p_PhoneNumber = phone;
            p_MailingAddress = mailing;
            p_PrivacyChoice = choice;
            //log.Add(new Logs() { changes = "User has been created with StudentID: " + p_StudentID });
        }

        //Public getters and setters
        public string Name
        {
            get { return p_Name; }
            set
            {
                p_Name = value;
                //log changes
               // log.Add(new Logs() {changes="Name has been changed for user to Name " + p_Name});
            }
        }
        public double StudentID
        {
            get { return p_StudentID; }
        }
        public string Major
        {
            get { return this.p_Major; }
            set
            {
                this.p_Major = value;
            }
        }
        public string StartDate
        {
            get {return p_StartDate; }
            set
            {
                p_StartDate = value;
            }
        }
        public string GradDate
        {
            get { return p_GradDate;  }
            set
            {
                p_GradDate = value;
            }
        }
        public string State
        {
            get { return p_State; }
            set
            {
                p_State = value;
            }
        }
        public string Country
        {
            get { return p_Country; }
            set
            {
                p_Country = value;
            }
        }
        public string EmailAddress
        {
            get { return p_EmailAddress; }
            set
            {
                p_EmailAddress = value;
            }
        }
        public string PhoneNumber
        {
            get { return p_PhoneNumber; }
            set
            {
                p_PhoneNumber = value;
            }
        }
        public string MailingAddress
        {
            get { return p_MailingAddress; }
            set
            {
                p_MailingAddress = value;
            }
        }
        public bool PrivacyChoice
        {
            get { return p_PrivacyChoice; }
            set
            {
                p_PrivacyChoice = value;
            }
        }
        //Private
        private string p_Name;
        private double p_StudentID;
        private string p_Major;
        private string p_StartDate;
        private string p_GradDate;
        private string p_State;
        private string p_Country;
        private string p_EmailAddress;
        private string p_PhoneNumber;
        private string p_MailingAddress;
        private bool p_PrivacyChoice;

        //Functions 
        public void printStudentInfo()
        {
           if (PrivacyChoice == true)
            {
                Console.WriteLine("StudentID: " + StudentID);
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("User has chosen to not have other information publicly available for them. ");
            } else
            {
                Console.WriteLine("StudentID: " + StudentID);
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Major: " + Major);
                Console.WriteLine("Email: " + EmailAddress);
                Console.WriteLine("Phone Number: " + PhoneNumber);
                Console.WriteLine("Start Date: " + StartDate);
                Console.WriteLine("Expected Grad Date: " + GradDate );
                Console.WriteLine("State: " + State);
                Console.WriteLine("Country: " + Country);
                Console.WriteLine("Mailing Address: " + MailingAddress);
            }
        }

    }
}
