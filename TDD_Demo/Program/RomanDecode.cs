using System;
using System.Collections.Generic;

namespace Program
{
    public class RomanDecode
    {
        public int ConvertToDecimal(string roman)
        {
            Dictionary<char, int> romanSymbols = new Dictionary<char, int>
                                                { { 'I', 1 }, { 'V', 5 }, { 'X', 10 },
                                                { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };

            int index = 0;
            int result = 0;

            while (index < roman.Length - 1)
            {
                if (romanSymbols[roman[index]] < romanSymbols[roman[index + 1]])
                {
                    result += (romanSymbols[roman[index + 1]] - romanSymbols[roman[index]]);
                    index += 2;
                }
                else
                {
                    result += romanSymbols[roman[index]];
                    index++;
                }
            }

            if (index == roman.Length - 1)
                result += romanSymbols[roman[index]];

            return result;
        }
    }
}
