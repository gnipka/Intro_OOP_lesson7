using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_OOP_lesson7
{
    /// <summary>
    /// Класс шифрует строку посредством сдвига каждого символа на одну «алфавитную» позицию выше
    /// </summary>
    class ACoder : ICoder
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
                //Если символ из текущий строки - это последний символ алфавита, то записываем первый символ алфавита
                else if (str[i] == valueList[valueList.Count - 1])
                    result += valueList[0];
                else
                    result += valueList[valueList.FindIndex(x => x == str[i]) + 1];
            }
            return result;
        }

        public string Decode(string str)
        {
            string result = String.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                List<char> valueList = Alphabet.ReturnAlphabet(str[i]);

                //Если символ не принадлежит ни к одному из алфавитов, возвращаем тот же символ
                if (valueList == null)
                    result += str[i];
                //Если символ из текущий строки - это последний символ алфавита, то записываем первый символ алфавита
                else if (str[i] == valueList[0])
                    result += valueList[valueList.Count - 1];
                else
                    result += valueList[valueList.FindIndex(x => x == str[i]) - 1];
            }
            return result;
        }
    }
}
