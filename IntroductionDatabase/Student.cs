using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntroductionDatabase
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get;  set; }
        public string MiddleName { get;  set; }
        public string Phone { get;  set; }
        public string Address { get;  set; }
        public string RegNo { get;  set; }

        public Student(string firstName, string middleName, string phone, string address, string regNo)
        {
            
            FirstName = firstName;
            MiddleName = middleName;
            Phone = phone;
            Address = address;
            RegNo = regNo;
        }
    }
}