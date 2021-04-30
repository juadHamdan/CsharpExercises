using System;
using System.Text;
using static B21_Ex01_4.Ex01_4;

namespace B21_Ex01_6
{
     public class Ex01_6
     {
          private const int k_InputLength = 6;
          private const int k_DivBy = 3;

          public static void NumStats()
          {
               string stringInput = getValidInputByLength(k_InputLength);
               char biggestDigit = findBiggetsDigit(stringInput);
               char smallestDigit = findSmallestDigit(stringInput);
               int howManyDigitsDivBy3 = howManyStrDigitsDivByDigit(stringInput, k_DivBy);
               int numOfDigitsAreBiggerThanUnitsDigit = howManyDigitsAreBiggerThanUnitsDigit(stringInput);
               string msg;

               msg = string.Format(
@"Biggest digit is: {0}
Smallest digit is: {1}
Amount of digits that are divisible by 3: {2}
Amount of digits that are bigger than the units digit: {3}", 
biggestDigit,
smallestDigit,
howManyDigitsDivBy3,
numOfDigitsAreBiggerThanUnitsDigit);
               Console.WriteLine(msg);
          }

          private static string getValidInputByLength(int i_InputLength)
          {
               string stringInput = GetInputByLength(i_InputLength);
               bool IsInputNumeric = IsNumeric(stringInput);
               bool isInputPositive = int.Parse(stringInput) >= 0;
               bool isValidInput = IsInputNumeric && isInputPositive;

               while (!isValidInput)
               {
                    Console.WriteLine("Wrong input, try again.\n");
                    stringInput = GetInputByLength(i_InputLength);
                    IsInputNumeric = IsNumeric(stringInput);
                    isInputPositive = int.Parse(stringInput) >= 0;
                    isValidInput = IsInputNumeric && isInputPositive;
               }

               return stringInput;
          }

          private static char findBiggetsDigit(string i_Str)
          {
               char biggestDigit = i_Str[0];

               for(int i = 1; i < i_Str.Length; i++)
               {
                    if(i_Str[i - 1] < i_Str[i])
                    {
                         biggestDigit = i_Str[i];
                    }
               }

               return biggestDigit;
          }

          private static char findSmallestDigit(string i_Str)
          {
               char smallestDigit = i_Str[0];

               for (int i = 1; i < i_Str.Length; i++)
               {
                    if (i_Str[i - 1] > i_Str[i])
                    {
                         smallestDigit = i_Str[i];
                    }
               }

               return smallestDigit;
          }

          private static int howManyStrDigitsDivByDigit(string i_Str, int i_divBy)
          {
               int numOfDigitsDivByDig = 0;

               for (int i = 0; i < i_Str.Length; i++)
               {
                    if (IsDivByDigit((long)char.GetNumericValue(i_Str[i]), i_divBy))
                    {
                         numOfDigitsDivByDig++;
                    }
               }

               return numOfDigitsDivByDig;
          }

          private static int howManyDigitsAreBiggerThanUnitsDigit(string i_Str)
          {
               char unitsDigit = i_Str[i_Str.Length - 1];
               int numOfDigitsBiggerThanUnitsDigit = 0;

               for (int i = 0; i < i_Str.Length - 1; i++)
               {
                    if (i_Str[i] > unitsDigit)
                    {
                         numOfDigitsBiggerThanUnitsDigit++;
                    }
               }

               return numOfDigitsBiggerThanUnitsDigit;
          }
     }
}