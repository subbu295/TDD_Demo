using System;

namespace Program
{
    public class RomanDecode
    {
        public int ConvertToDecimal(string Roman)
        {
            if (Roman == "I")
                return 1;

            if (Roman == "V")
                return 5;

            return 0;
        }
    }
}
