using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_OOP_lesson7
{
    class BCoder : ICoder
    {
        public string Encode(string str)
        {
            string result = String.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                List<char> valueList = Alphabet.ReturnAlphabet(str[i]);

                //Если символ не принадлежит ни к одному из алфавитов, возвращаем тот же символ
                if (valueList == null)
                    result += str[i];
                else
                    result += valueList[valueList.Count - valueList.FindIndex(x => x == str[i]) - 1];
            }
            return result;
        }

        public string Decode(string str)
        {
            return Encode(str);
        }
    }
}
