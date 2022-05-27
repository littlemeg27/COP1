using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9A
{
    public class Submission
    {
        public static Student[] enrollment = new Student[0];

        public static Student Test1(string last, string first, int idNo)
        {
            Student student = new Student(last, first, idNo);
            
            return student;
        }

        public static Student Test2()
        {
            Student students = new Student();

            return students;
        }

        public static bool Test3(Student enrolled)
        {
            bool enrollmentTest = false;

            for(int i = 0; i < enrollment.Length; i++)
            {
                if(enrollment[i] == null)
                {
                    enrollment[i] = enrolled;
                    enrollmentTest = true;
                    break;
                }
            }
            return enrollmentTest;
        }

        public static bool Test4(int idNumber)
        {
            bool idNumberTest = false;

            for (int i = 0; i < enrollment.Length; i++)
            {
                if (enrollment[i] != null && enrollment[i].GetIDNumber() == idNumber)
                {
                    enrollment[i] = null;
                    idNumberTest = true;
                    break;
                }
            }
            return idNumberTest;
        }

        public static Student Test5(int idNumber)
        {
            Student student = null;
            Student[] enrollment = Submission.enrollment;

            for(int i = 0; i < enrollment.Length; i++)
            {
                Student newStudent = enrollment[i];

                if ((newStudent == null) || (newStudent.GetIDNumber() != idNumber))
                {
                    student = newStudent;
                }
             
            }
            return student;
        }

    }

}
