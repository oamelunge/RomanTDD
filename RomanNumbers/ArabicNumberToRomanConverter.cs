using System.IO;

namespace RomanNumbers
{
    public class ArabicNumberToRomanConverter
    {
        public string value(int numberToConvert)
        {
            StringWriter romanNumber = new StringWriter();

            ArabicDigitToRomanDigitConverter.ConvertDigit(numberToConvert / 100 % 10, romanNumber, "C", "D", "M");
            ArabicDigitToRomanDigitConverter.ConvertDigit(numberToConvert/10 % 10, romanNumber, "X", "L", "C");
            ArabicDigitToRomanDigitConverter.ConvertDigit(numberToConvert % 10, romanNumber, "I", "V", "X");          
            return romanNumber.ToString();
        }
    }
}