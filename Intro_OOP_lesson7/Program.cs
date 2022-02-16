using System;

namespace Intro_OOP_lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "hello HELLO привет ПРИВЕТ";

            ACoder aCoder = new ACoder();
            string strEncodeA = aCoder.Encode(str);
            string strDecodeA = aCoder.Decode(strEncodeA);

            BCoder bCoder = new BCoder();
            string strEncodeB = bCoder.Encode(str);
            string strDecodeB = bCoder.Decode(strEncodeB);

        }
    }
}
