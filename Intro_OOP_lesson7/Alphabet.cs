using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_OOP_lesson7
{
    public static class Alphabet
    {
        private const int borderLeftRuUp = 1040;
        private const int borderRightRuUp = 1072;
        private const int borderLeftRuLow = 1072;
        private const int borderRightRuLow = 1104;
        private const int borderLeftEnUp = 65;
        private const int borderRightEnUp = 91;
        private const int borderLeftEnLow = 97;
        private const int borderRightEnLow = 123;

        /// <summary>
        /// русский алфавит (верхний регистр)
        /// </summary>
        static List<char> AlphabetRuUp;
        /// <summary>
        /// русский алфавит (нижний регистр)
        /// </summary>
        static List<char> AlphabetRuLow;
        /// <summary>
        /// английский алфавит (верхний регистр)
        /// </summary>
        static List<char> AlphabetEnUp;
        /// <summary>
        /// английский алфавит (нижний регистр)
        /// </summary>
        static List<char> AlphabetEnLow;

        /// <summary>
        /// Заполняет русский алфавит верхний регистр
        /// </summary>
        static void FillAlphaRuUp()
        {
            AlphabetRuUp = new List<char>();
            for (int i = borderLeftRuUp; i < borderRightRuUp; i++)
            {
                AlphabetRuUp.Add((char)i);
            }
        }

        /// <summary>
        /// Заполняет русский алфавит нижний регистр
        /// </summary>
        static void FillAlphaRuLow()
        {
            AlphabetRuLow = new List<char>();
            for (int i = borderLeftRuLow; i < borderRightRuLow; i++)
            {
                AlphabetRuLow.Add((char)i);
            }
        }

        /// <summary>
        /// Заполняет английский алфавит верхний регистр
        /// </summary>
        static void FillAlphaEnUp()
        {
            AlphabetEnUp = new List<char>();
            for (int i = borderLeftEnUp; i < borderRightEnUp; i++)
            {
                AlphabetEnUp.Add((char)i);
            }
        }

        /// <summary>
        /// Заполняет английский алфавит нижний регистр
        /// </summary>
        static void FillAlphaEnLow()
        {
            AlphabetEnLow = new List<char>();
            for (int i = borderLeftEnLow; i < borderRightEnLow; i++)
            {
                AlphabetEnLow.Add((char)i);
            }
        }

        /// <summary>
        /// Возвращает алфавит, которому принадлежит символ
        /// </summary>
        /// <param name="i">символ строки для шифрования</param>
        /// <returns></returns>
        public static List<char> ReturnAlphabet(char i)
        {
            if (i >= (char)borderLeftRuLow && i < (char)borderRightRuLow) 
            {
                if(AlphabetRuLow == null)
                {
                    FillAlphaRuLow();
                }
                return AlphabetRuLow;
            }

            if (i >= (char)borderLeftRuUp && i < (char)borderRightRuUp)
            {
                if (AlphabetRuUp == null)
                {
                    FillAlphaRuUp();
                }
                return AlphabetRuUp;
            }

            if (i >= (char)borderLeftEnLow && i < (char)borderRightEnLow)
            {
                if (AlphabetEnLow == null)
                {
                    FillAlphaEnLow();
                }
                return AlphabetEnLow;
            }

            if (i >= (char)borderLeftEnUp && i < (char)borderRightEnUp)
            {
                if (AlphabetEnUp == null)
                {
                    FillAlphaEnUp();
                }
                return AlphabetEnUp;
            }

            else
                return null;
        }
    }
}
