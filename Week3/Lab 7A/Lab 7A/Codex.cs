//COP1
//Lab 7
//Brenna Pavlinchak

using System.Text;
using System;


namespace TextCodec
{
    public class Codex
    {
        sbyte theOffset;

        public Codex(sbyte offset)
        {
            theOffset = offset;
        }

        public string Encode(string message)
        {
            StringBuilder stringBuilder = new StringBuilder(message);

            for(int i = 0; i < message.Length; i++)
            {
                stringBuilder[i] = (char)(stringBuilder[i] + theOffset);
            }
            return stringBuilder.ToString();
        }

        public string Decode(string message)
        {
            StringBuilder stringBuilder = new StringBuilder(message);

            for (int i = 0; i < message.Length; i++)
            {
                stringBuilder[i] = (char)(stringBuilder[i] - theOffset);
            }
            return stringBuilder.ToString();
        }


    }
}
