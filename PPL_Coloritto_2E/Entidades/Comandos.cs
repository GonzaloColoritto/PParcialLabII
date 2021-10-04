using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Entidades
{
    public static class Comandos
    {
        /// <summary>
        /// Verificara que el string que se pasa por parametro contenga unicamente letras
        /// </summary>
        /// <param name="s"></param>
        /// <returns>retornara true si tiene todo letras, retornara false sino</returns>
        public static bool IsAllLetters(string s) 
        { 
            foreach (char c in s) 
            { if (!Char.IsLetter(c)) 
                    return false; 
            } 
            return true; 
        }

    }
}
