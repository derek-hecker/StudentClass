using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;


namespace StudentClass
{
    public class Student : StudentClass
    {
        string test;
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
                test += "\n" + Name + ": Name has been changed";
            }
        }
        public double StudentID
        {
            get { return p_StudentID; }
        }
        public string Major
        {
            get {
                if (PrivacyChoice == false)
                {
                    return this.p_Major;
                }
                else return "Private";
            }
            set
            {
                this.p_Major = value;
                test += "\n" + Name + ": Major has been changed";
            }
        }
        public string StartDate
        {
            get
            {
                if (PrivacyChoice == false)
                {
                    return this.p_StartDate;
                }
                else return "Private";
            }
            set
            {
                p_StartDate = value;
                test += "\n" + Name + ":start date has been changed";
            }
        }
        public string GradDate
        {
            get
            {
                if (PrivacyChoice == false)
                {
                    return this.p_GradDate;
                }
                else return "Private";
            }
            set
            {
                p_GradDate = value;
                test += "\n" + Name + ": Grad Date has been changed";
            }
        }
        public string State
        {
            get
            {
                if (PrivacyChoice == false)
                {
                    return this.p_State;
                }
                else return "Private";
            }
            set
            {
                p_State = value;
                test += "\n" + Name + ": State Address has been changed";
            }
        }
        public string Country
        {
            get
            {
                if (PrivacyChoice == false)
                {
                    return this.p_Country;
                }
                else return "Private";
            }
            set
            {
                p_Country = value;
                test += "\n" + Name + ": Country has been changed";
            }
        }
        public string EmailAddress
        {
            get
            {
                if (PrivacyChoice == false)
                {
                    return this.p_EmailAddress;
                }
                else return "Private";
            }
            set
            {
                p_EmailAddress = value;
                test += "\n" + Name + ": Email Address has been changed";
            }
        }
        public string PhoneNumber
        {
            get
            {
                if (PrivacyChoice == false)
                {
                    return this.p_PhoneNumber;
                }
                else return "Private";
            }
            set
            {
                p_PhoneNumber = value;
                test += "\n" + Name + ": Phone Number has been changed";
            }
        }
        public string MailingAddress
        {
            get
            {
                if (PrivacyChoice == false)
                {
                    return this.p_MailingAddress;
                }
                else return "Private";
            }
            set
            {
                p_MailingAddress = value;
                test += "\n" + Name + ": Mailing Address has been changed";
            }
        }
        public bool PrivacyChoice
        {
            get { return p_PrivacyChoice; }
            set
            {
                p_PrivacyChoice = value;
                test += Name + ": Privacy Choice has been changed";
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
        //Log List Declaration

        //Functions 
        public void printStudentInfo()
        {
           if (PrivacyChoice == true)
            {
                Console.WriteLine("StudentID: " + StudentID);
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("User has chosen to not have other information publicly available for them. ");
                Console.WriteLine("");
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
                Console.WriteLine("");
            }
        }
        public void printLog()
        {
            Console.WriteLine(test);
        }

    }
}
