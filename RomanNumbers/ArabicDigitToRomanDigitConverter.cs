using System.IO;

namespace RomanNumbers
{
    public class ArabicDigitToRomanDigitConverter
    {
        public static void ConvertDigit(int numberToConvert, StringWriter romanNumber, string one, string five, string ten)
        {
            if (numberToConvert <= 3)
            {
                for (int i = 0; i < numberToConvert; i++)
                    romanNumber.Write(one);
            }
            else if (numberToConvert == 4)
                romanNumber.Write(one+five);
            else if (numberToConvert >= 5 && numberToConvert <= 8)
            {
                romanNumber.Write(five);
                for (int i = 5; i < numberToConvert; i++)
                    romanNumber.Write(one);
            }
            else if (numberToConvert == 9)
                romanNumber.Write(one+ten);
        }
    }
}