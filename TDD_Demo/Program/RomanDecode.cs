using System;
using System.Collections.Generic;

namespace Program
{
    public class RomanDecode
    {
        public int ConvertToDecimal(string roman)
        {
            Dictionary<char, int> romanSymbols = new Dictionary<char, int> { { 'I', 1 }, { 'V', 5 } };

            int index = 0;
            int result = 0;

            while (index < roman.Length)
            {
                result += romanSymbols[roman[index]];
                index++;
            }

            return result;
        }
    }
}
