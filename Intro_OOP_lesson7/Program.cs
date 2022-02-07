using System;

namespace Intro_OOP_lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            ACoder aCoder = new ACoder();
            string str = "hello HELLO привет ПРИВЕТ";
            string strEncode = aCoder.Encode(str);
            string strDecode = aCoder.Decode(strEncode);

        }
    }
}
