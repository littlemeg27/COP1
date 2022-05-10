using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSPG1
{
    class Submission
    {
        string input = "75";
      
        /*
         * 
         * For this lab you are required to use the Parse() method 
         * for each conversion. No credit will be given for calls
         * using the Convert class (i.e. Convert.ToInt32)
         * 
        */

        // Given a string, using the Int32 class, convert the string 
        // to an integer. Return the integer
        public static int Test3(string input)
        {
            int number;
            number = Int32.Parse(input);
            return number;
        }

        // Given a string, using the SByte class, convert the string 
        // to a signed byte. Return the signed byte
        public static sbyte Test4(string input)
        {
            sbyte number;
            number = SByte.Parse(input);
            return number;
        }

        // Given a string, using the Double class, convert the string 
        // to a double Return the double
        public static double Test5(string input)
        {
            double number;
            number = Double.Parse(input);
            return number;
        }

        // Given a string, using the UInt16 class, convert the string
        // to a unsigned short. Return the unsigned short
        public static ushort Test6(string input)
        {
            ushort number;
            number = UInt16.Parse(input);
            return number;
        }

        // Given a string, using the Single class, convert the string 
        // to a float. Return the float
        public static float Test7(string input)
        {
            float number;
            number = Single.Parse(input);
            return number;
        }

        // Given a string, using the UInt32 class, convert the string 
        // to an unsigned integer. Return the unsigned integer
        public static uint Test8(string input)
        {
            uint number;
            number = UInt32.Parse(input);
            return number;
        }

        // Given a string, using the Int16 class, convert the string 
        // to a short. Return the short
        public static short Test9(string input)
        {
            short number;
            number = Int16.Parse(input);
            return number;
        }

        // Given a string, using the UInt64 class, convert the string 
        // to an unsigned long. Return the unsigned long
        public static ulong Test10(string input)
        {
            ulong number;
            number = UInt64.Parse(input);
            return number;
        }
    }
}
