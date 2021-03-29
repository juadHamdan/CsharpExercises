using System;
using System.Text;
using static B21_Ex01_4.Ex01_4;

namespace B21_Ex01_6
{
     class Ex01_6
     {
          private const int k_InputLength = 6;
          private const int k_DivBy = 3;


          public static void NumStats()
          {
               //GetInputByLength need to be in a separate function to check :
               // GetInputByLength && IsNumeric
               string stringInput = GetInputByLength(k_InputLength);

               char biggestDigit = FindBiggetsDigit(stringInput);
               char smallestDigit = FindSmallestDigit(stringInput);

               int howManyDigitsDivBy3 = HowManyStrDigitsDivByDigit(stringInput, k_DivBy);

               int howManyDigitsAreBiggerThanUnitsDigit = HowManyDigitsAreBiggerThanUnitsDigit(stringInput);
          }

          private static char FindBiggetsDigit(string i_Str)
          {
               return '4';
          }

          private static char FindSmallestDigit(string i_Str)
          {
               return '4';
          }

          private static int HowManyStrDigitsDivByDigit(string i_Str, int i_divBy)
          {
               return 0;
          }

          private static int HowManyDigitsAreBiggerThanUnitsDigit(string i_Str)
          {
               return 0;
          }
     }
}