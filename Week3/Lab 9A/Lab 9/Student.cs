using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9A
{
    public class Student
    {
        // Add member fields here

        private string lastName;
        private string firstName;
        private int studentID;

        public Student()
        {
            lastName = "";
            firstName = "";
            studentID = 1000000;
        }
        
        // Add default and overloaded constructors here

        public Student(string last, string first, int id)
        {
            lastName = last;
            firstName = first;
            studentID = id;
        }

        // add Getters and Setters here

        public string GetLastName() // Get for Last name 
        {
            return lastName;
        }

        public string GetFirstName() // Get for First name 
        {
            return firstName;
        }

        public int GetIDNumber() // Get for ID 
        {
            return studentID;
        }

        public void SetLastName(string last) // Set for Last name 
        {
            lastName = last;
        }

        public void SetFirstName(string first) // Set for First name 
        {
            firstName = first;
        }

        public void SetIDNumber(int id) // Set for student ID 
        {
            studentID = id;
        }


        /******************************************************************************************************
        *                                                                                                     *
        *                                                                                                     *
        *                                                                                                     *
        *                                                                                                     *
        *                      do not modify any of the following code                                        *
        *                                                                                                     *
        *                                                                                                     *
        *                                                                                                     *
        *                                                                                                     *
        *                                                                                                     *
        ******************************************************************************************************/
        public override string ToString()
        {
            return "ID #: " + GetIDNumber() + "\tName: " + GetLastName() + ", " + GetFirstName();
        }

        public override bool Equals(object obj)
        {
            bool same = true;
            Student s2 = (Student)obj;
            if (this.GetLastName() != s2.GetLastName() || this.GetFirstName() != s2.GetFirstName() || this.GetIDNumber() != s2.GetIDNumber())
            {
                same = false;
            }
            return same;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
