//COP1
//Lab 4A
//Brenna Pavlinchak

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSPG1
{
    public enum MathOperator //Creating and defining MathOperator Enum 
    {
        Add, //Added Values 
        Subtract,
        Multiply,
        Divide, 
        Modulo
    }

    public class Submissions
    {
        /*
         * This lab is NOT interactive - that means there should be no 
         * calls to the Console class (no Write/WriteLine/ReadLine/ReadKey)
         * 
         * 
         * This is Lab 4 - it is intended for you to demonstrate your 
         * understanding of selection statements (if and switch). This means
         * you are required to use either a switch or if statement for all
         * Test solutions (Test6 is an exception to this rule). For Test6, you
         * are permitted to simply 'pass through' the value returned by the 
         * Equals method.
         * 
         * 
         * Note: Your program will not compile until you complete the 
         * MathOperator enum (Tests 1 & 2)
         * 
         * Additional reminders. In PG1:
         *      1. Methods are not permitted to use more than 1 return statement
         *      2. You are not allowed to use the Convert class
         *      3. You are not allowed to use var in place of a known data type
         */


        // Before beginning Tests 1 and 2, you need to define an enum named
        // MathOperator with five values: Add, Subtract, Multiply, Divide and
        // Modulo. The enum should not be 'nested' within a class (it should 
        // be defined in the namespace, but outside all classes). X
        //
        //
        // For Test1, After creating the enum, you are to return a MathOperator
        // value based on the value of the parameter provided: 
        //
        // 0 = MathOperator.Add
        // 1 = MathOperator.Subtract
        // 2 = MathOperator.Multiply
        // 3 = MathOperator.Divide
        // 4 = MathOperator.Modulo
        //
        // You do not need to worry about/handle any other possible input values (the
        // only values passed to the method will be 0, 1, 2, 3 or 4)

        public static MathOperator Test1(int input)
        {
            int values = 0;

            switch (input)
            { 
                case 0:
                    values = 0;
                    break;

                case 1:
                    values = 1;
                    break;

                case 2:
                    values = 2;
                    break;

                case 3:
                    values = 3;
                    break;

                default:
                    values = 4;
                    break;
            }
            return (MathOperator)values;
        }

        // Test2 - Use the MathOperator enum you developed for Test1 to decide what
        // operation to perform on the two int values provided. Return the result of
        // performing the indicated operation on the int values.

        public static int Test2(int number1, int number2, MathOperator operation)
        {
            int values = 0;

            switch(operation)
            {
                case MathOperator.Add:
                    values = number1 + number2;
                    break;

                case MathOperator.Subtract:
                    values = number1 - number2;
                    break;

                case MathOperator.Multiply:
                    values = number1 * number2;
                    break;

                case MathOperator.Divide:
                    values = number1 / number2;
                    break;

                default:
                    values = number1 % number2;
                    break;
            }
            return values;
        }

        // Test3 - Given a bool parameter, return a string indicating
        // the related term. When the bool is true return "Proven", 
        // when the bool is false return "Denied". Again remember all
        // identifiers are case sensitive. For this Test, the string's 
        // case does not matter

        public static string Test3(bool input)
        {
            string amount = "Denied";
            input = true;

            if (input == false)
            {
                amount = "Proven";
            }

            return amount;
        }

        // Test4 - Given a weight in either kilograms or pounds and a
        // bool, you will either convert kilograms to pounds (when the 
        // bool is true) or pounds to kilograms (when the bool is
        // false). Return the result rounded to 3 decimal places
        // (use Math.Round)
        // The conversions are:
        // 1 kg = 2.20462 lb
        // 1 lb = 0.453592 kg

        public static double Test4(double input, bool kiloToLb)
        {
            double conversion = 0;

            if (kiloToLb == false)
            {
                conversion = input * 0.453592;
            }
            else if(kiloToLb == true)
            {
                conversion = input * 2.20462;
            }

            return Math.Round(conversion, 3);
        }

        // Test5 - Given an int that represents the severity of an employee infraction,
        // return the associated action required as a string.
        //   Infraction Severity            Required Action
        //        Level 1                   Verbal Reprimand
        //        Level 2                   Formal Reprimand
        //        Level 3                   Suspension
        //        Level 4                   Termination
        // Keep in mind, action required must be spelled correctly
        // (exactly as above) but are not case sensitive


        public static string Test5(int input)
        {
            string infractionType = "";

            if(input == 1)
            {
                infractionType = "Verbal Reprimand";
            }
            else if(input == 2)
            {
                infractionType = "Formal Reprimand";
            }
            else if (input == 3)
            {
                infractionType = "Suspension";
            }
            else if (input == 4)
            {
                infractionType = "Termination";
            }
            return infractionType;
        }

        // Test6 - Use an object's Equal method. Given two Triangle objects,
        // use their Equals method to determine if the two objects are equal.
        // Keep in mind, the Equals method is not the same as the  equality
        // operator (==). The Equals method evaluates the value of the 
        // contents of each object while the equality operator (==) will
        // evaluate if both references are the same (the same object).
        // Additionally, for this lab you are required to use the Equals
        // method that accepts a single parameter.

        public static bool Test6(Triangle t1, Triangle t2)
        {
            bool parameter = false;

            if(t1.Equals(t2))
            {
                parameter = true;
            }

            return parameter;
        }

        // Given the three sides of a Triangle, determine if the triangle
        // is a Right Triangle. A triangle where the sum of the squares
        // of the two shortest sides (a and b) is equal to the square of 
        // longest side (c) is a 'Right' triangle. The third parameter
        // (c) will always be the longest side given.

        public static bool Test7(int a, int b, int c)
        {
            bool longest = false;

            if((a * a) + (b * b)  == (c * c))
            {
                longest = true;
            }
            return longest;
        }

        // Given the grade variable, which indicates a student's numeric grade, 
        // determine which letter grade they should receive. Return the proper 
        // letter (char) as the result of this test. Do not worry about rounding 
        // the grade. Use the following table to indicate which letter corresponds 
        // to provided grades.
        // Use if and else-if for Test8
        // Remember only one return statement is allowed
        //  >= 90 and <= 100 	'A'
        //  >= 80 and< 90 	    'B'
        //  >= 73 and< 80    	'C'
        //  >= 70 and< 73 	    'D'
        //  >= 0 and< 70 	    'F'
        //  < 0 or> 100 	    '?'

        public static char Test8(double grade)
        {
            char gradeLabel = '0';

            if(grade >= 90 && grade <= 100)
            {
                gradeLabel = 'A';
            }
            else if(grade >= 80 && grade < 90)
            {
                gradeLabel = 'B';
            }
            else if (grade >= 73 && grade < 80)
            {
                gradeLabel = 'C';
            }
            else if (grade >= 70 && grade < 73)
            {
                gradeLabel = 'D';
            }
            else if (grade >= 0 && grade < 70)
            {
                gradeLabel = 'F';
            }
            else if (grade < 0 || grade > 100)
            {
                gradeLabel = '?';
            }

            return gradeLabel;
        }
    }
}
