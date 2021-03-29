using System;
using System.Text;

namespace B21_Ex01_4
{
     public class Ex01_4
     {
          const int k_InputLength = 10;
          const int k_DivBy = 4;

          public static void StringAnalysis()
          {
               //GetInputByLength need to be in a separate function to check :
               // GetInputByLength && (IsNumeric || IsAlpha)
               string stringInput = GetInputByLength(k_InputLength);
               bool isInputNumeric = IsNumeric(stringInput);
               bool isInputAlpha = IsAlpha(stringInput);

               bool isInputEngAlpha;
               int numOfEngUpperCase;

               if (isInputAlpha)
               {
                    isInputEngAlpha = IsEngAlpha(stringInput);

                    if (IsPalindromeRec(stringInput))
                    {
                         Console.WriteLine("The input is palindrome.");
                    }
                    if (isInputEngAlpha)
                    {
                         numOfEngUpperCase = GetNumOfUpperCaseLetters(stringInput);
                         string.Format("The number of upper case letters is: {0}", numOfEngUpperCase);
                    }
               }
               if (isInputNumeric)
               {
                    if (IsDivByDigit(int.Parse(stringInput)), k_DivBy)
                    {
                         Console.WriteLine("The number is divisible by 4.");
                    }
               }
          }

          public static string GetInputByLength(int i_Num)
          {
               Console.WriteLine("Enter a string: ");
               string stringInput = Console.ReadLine();


               return stringInput;
          }


          public static bool IsNumeric(string i_Str)
          {
               return true;
          }

          public static bool IsAlpha(string i_Str)
          {
               return true;

          }

          public static bool IsEngAlpha(string i_Str)
          {
               return true;

          }

          public static bool IsPalindromeRec(string i_Str)
          {
               return true;

          }

          public static int GetNumOfUpperCaseLetters(string i_Str)
          {
               return 0;

          }

          public static bool IsDivByDigit(int i_Num, int i_Digit)
          {
               return true;

          }

     }
}