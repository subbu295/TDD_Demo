using System;
using System.Collections.Generic;

namespace Program
{
    public class RomanDecode
    {
        public int ConvertToDecimal(string romanNumber)
        {
            if (string.IsNullOrEmpty(romanNumber))
            {
                throw new Exception("Invalid roman number string.");
            }

            Dictionary<char, int> romanSymbols = new Dictionary<char, int>
                                                { { 'I', 1 }, { 'V', 5 }, { 'X', 10 },
                                                { 'L', 50 }, { 'C', 100 }, { 'D', 500 },
                                                { 'M', 1000 } };

            int index = 0;
            int result = 0;

            while (index < romanNumber.Length)
            {
                char firstChar = romanNumber[index];
                char secondChar = romanNumber[index];

                if (!romanSymbols.ContainsKey(firstChar))
                {
                    throw new Exception("Invalid roman number string.");
                }

                if (index != romanNumber.Length - 1)
                {
                    secondChar = romanNumber[index + 1];
                }                              

                if (romanSymbols[firstChar] < romanSymbols[secondChar])
                {
                    result += (romanSymbols[secondChar] - romanSymbols[firstChar]);
                    index += 2;
                }
                else
                {
                    result += romanSymbols[firstChar];
                    index++;
                }
            }           

            return result;
        }
    }
}
