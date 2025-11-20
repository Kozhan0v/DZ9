using System;
using System.Text;
using Tumakov.Interfaces;

namespace Tumakov.Classes
{
    internal class BCipher : ICipher
    {
        private static char[] _upperAlphabet = {
            'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й',
            'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф',
            'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я'
        };
        private static char[] _lowerAlphabet = {
            'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й',
            'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф',
            'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я'
        };

        public BCipher()
        {

        }

        public string Encode(string text)
        {
            int indexOfSymb;
            char[] charText = text.ToCharArray();

            for (int i = 0; i < charText.Length; i++)
            {
                if (char.IsUpper(charText[i]))
                {
                    indexOfSymb = Array.IndexOf(_upperAlphabet, charText[i]);

                    charText[i] = _upperAlphabet[32 - indexOfSymb];
                }
                else if (char.IsLower(charText[i]))
                {
                    indexOfSymb = Array.IndexOf(_lowerAlphabet, charText[i]);

                    charText[i] = _lowerAlphabet[32 - indexOfSymb];
                }
                else
                {
                    continue;
                }
            }

            return new string(charText);
        }

        public string Decode(string text)
        {
            return this.Encode(text);
        }    
    }
}
