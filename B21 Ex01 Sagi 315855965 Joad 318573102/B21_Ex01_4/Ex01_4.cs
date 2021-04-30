using System;
using System.Text;

namespace B21_Ex01_4
{
     public class Ex01_4
     {
          private const int k_InputLength = 10;
          private const int k_DivBy = 4;

          public static void StringAnalysis()
          {
               string stringInput = getValidInputByLength(k_InputLength);
               bool isInputNumeric = IsNumeric(stringInput);
               bool isInputAlpha = isAlpha(stringInput);
               int numOfEngUpperCase;
               StringBuilder msg = new StringBuilder();

               if (isPalindromeRec(stringInput))
               {
                    msg.Append("The input is palindrome.\n");
               }

               if (isInputAlpha)
               {
                    numOfEngUpperCase = getNumOfUpperCaseLetters(stringInput);
                    msg.AppendFormat(string.Format("The number of upper case letters is: {0}\n", numOfEngUpperCase));
               }

               if (isInputNumeric)
               {
                    if (IsDivByDigit(long.Parse(stringInput), k_DivBy))
                    {
                         msg.Append("The number is divisible by 4.\n");
                    }
               }

               Console.WriteLine(msg);
          }

          public static string GetInputByLength(int i_Num)
          {
               string stringInput;

               Console.WriteLine("Enter a string: ");
               stringInput = Console.ReadLine();

               while (stringInput.Length != i_Num)
               {
                    Console.WriteLine("Wrong Input length, please enter another string: ");
                    stringInput = Console.ReadLine();
               }

               return stringInput;
          }

          private static string getValidInputByLength(int i_InputLength)
          {
               string stringInput = GetInputByLength(i_InputLength);
               bool isInputNumeric = IsNumeric(stringInput);
               bool isInputAlpha = isAlpha(stringInput);
               bool isValidInput = isInputNumeric || isInputAlpha;

               while (!isValidInput)
               {
                    Console.WriteLine("Wrong input, try again.\n");
                    stringInput = GetInputByLength(i_InputLength);
                    isInputNumeric = IsNumeric(stringInput);
                    isInputAlpha = isAlpha(stringInput);
                    isValidInput = isInputNumeric || isInputAlpha;
               }

               return stringInput;
          }

          public static bool IsNumeric(string i_Str)
          {
               bool isNumeric = true;

               for (int i = 0; i < i_Str.Length; i++)
               {
                    if (!char.IsDigit(i_Str[i]))
                    {
                         isNumeric = false;
                    }
               }

               return isNumeric;
          }

          private static bool isAlpha(string i_Str)
          {
               bool isNumeric = true;

               for (int i = 0; i < i_Str.Length && isNumeric; i++)
               {
                    if (!char.IsLetter(i_Str[i]))
                    {
                         isNumeric = false;
                    }
               }

               return isNumeric;
          }

          private static bool isPalindromeRec(string i_Str)
          {
               bool isPali;

               if (i_Str.Length == 0 || i_Str.Length == 1)
               {
                    isPali = true;
               }
               else if (Math.Equals(i_Str[0], i_Str[i_Str.Length - 1]))
               {
                    isPali = isPalindromeRec(i_Str.Substring(1, i_Str.Length - 2));
               }
               else
               {
                    isPali = false;
               }

               return isPali;
          }

          private static int getNumOfUpperCaseLetters(string i_Str)
          {
               int upperCaseCounter = 0;

               for (int i = 0; i < i_Str.Length; i++)
               {
                    if (char.IsUpper(i_Str[i]))
                    {
                         upperCaseCounter++;
                    }
               }

               return upperCaseCounter;
          }

          public static bool IsDivByDigit(long i_Num, int i_Digit)
          {
               return i_Num % i_Digit == 0;
          }
     }
}