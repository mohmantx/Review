using System;
using System.Collections.Generic;
using System.Text;

namespace StudentUMLExample
{
    public class Student
    {
        public int SoonerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsOnProbation { get; set; }
        public double GPA { get; set; }
        private double BursarBalance;

        /// <summary>
        /// Default/Empty Constructor
        /// </summary>
        public Student()
        {
            SoonerID = -1;
            FirstName = string.Empty;
            LastName = string.Empty;
            IsOnProbation = false;
            GPA = -1;
            BursarBalance = 1000;
        }

        public Student(int id, string fName, string LName, double BursarBalance)
        {
            SoonerID = id;
            FirstName = fName;
            LastName = LName;
            IsOnProbation = false;
            GPA = -1;
            this.BursarBalance = BursarBalance;
        }

        public void MakePayment(double amount)
        {
            //BursarBalance = BursarBalance - amount;
            if (amount > 0)
            {
                BursarBalance -= amount;
            }
            else
            {
                throw new Exception();
            }
        }

        public double CheckBalance()
        {
            return BursarBalance;
        }

        public override string ToString()
        {
            String output = $"{FirstName} {LastName} ({SoonerID})";
            if (IsOnProbation == true)
            {
                output += " is on probation";
            }
            else
            {
                output += " is NOT on probation";
            }

            return base.ToString();
        }
    }
}
