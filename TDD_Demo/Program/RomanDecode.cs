using System;
using System.Collections.Generic;

namespace Program
{
    public class RomanDecode
    {
        public int ConvertToDecimal(string roman)
        {
            Dictionary<string, int> romanSymbols = new Dictionary<string, int> { { "I", 1 }, { "V", 5 } };
            
            if (romanSymbols.ContainsKey(roman))
                return romanSymbols[roman];
                
            return 0;
        }
    }
}
