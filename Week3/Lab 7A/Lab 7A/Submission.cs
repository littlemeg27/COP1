//COP1
//Lab 7
//Brenna Pavlinchak

using System;
using System.Text;
using Lab_7A;
using TextCodec;

namespace FSPG1
{
    public class Submission
    {
        public static StringBuilder Test1(string [] names) // Test 1
        {
            StringBuilder namesBulider = new StringBuilder();

            for(int i = 0; i < names.Length; i++)
            {
                namesBulider.Append(names[i][0]);
            }

            return namesBulider;
        }

        public static object Test2(float x, float y, float radius) // Test 2 
        {
            Circle c1 = new Circle(x, y, radius);

            return c1;
        }

        public static object Test3(float x, float y, float radius) // Test 3 
        {
            Circle c1 = new Circle(x, y, radius);

            return c1;
        }

        public static object Test4(float x, float y, float radius) // Test 4
        {
            Circle c1 = new Circle(x, y, radius);

            return c1;
        }

        public static object Test5(float x, float y, float radius) // Test 5
        {
            Circle c1 = new Circle(x, y, radius);

            return c1;
        }

        public static int Test6(string str1, string str2, bool ignoreCase) // Test 6
        {

            return string.Compare(str1,str2,ignoreCase);
        }

        public static string Test7(sbyte offset, string message) // Test 7
        {
            Codex textCodec = new Codex(offset);

            return textCodec.Encode(message);
        }

        public static string Test8(sbyte offset, string message) // Test 8
        {
            Codex textCodec = new Codex(offset);

            return textCodec.Decode(message);
        }
    }
}
