using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_OOP_lesson7
{
    interface ICoder
    {
        /// <summary>
        /// Шифрование строки
        /// </summary>
        /// <param name="str">Строка для шифрования</param>
        string Encode(string str);
        /// <summary>
        /// Дешифрование строки
        /// </summary>
        /// <param name="str">Строка для дешифрования</param>
        string Decode(string str);
    }
}
