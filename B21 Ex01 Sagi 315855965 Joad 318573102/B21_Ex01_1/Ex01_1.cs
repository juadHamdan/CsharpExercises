using System;
using System.Text;

namespace B21_Ex01_1
{
     public class Ex01_1
     {
          private const int k_InputLength = 7;
          private const int k_HowManyInputs = 3;

          public static void BinarySeries()
          {
               StringBuilder dataAndStatsOutput = new StringBuilder();
               int howManyNumsArePowerOf2 = 0;
               int howManyNumsAnAscendingSeries = 0;
               int minNum = 0, maxNum = 0;
               float sumOfNumOfZerosInInput = 0;
               float avgNumOfZerosInInput, avgNumOfOnesInInput;

               Console.Write("Please enter the numbers: ");
               for (int i = 0; i < k_HowManyInputs; i++)
               {
                    string binStrInput = getBinStrFromUser();
                    int decInput = convertBinStrToDecNum(binStrInput);
                    if (i == 0)
                    {
                         maxNum = minNum = decInput;
                    }

                    sumOfNumOfZerosInInput += numOfZerosInString(binStrInput);
                    if (isBinStringPowerOf2(binStrInput))
                    {
                         howManyNumsArePowerOf2 += 1;
                    }

                    if (isDigitStrAnAscendingSeries(decInput.ToString()))
                    {
                         howManyNumsAnAscendingSeries += 1;
                    }
                    
                    if (decInput < minNum)
                    {
                         minNum = decInput;
                    }

                    if (decInput > maxNum)
                    {
                         maxNum = decInput;
                    }

                    dataAndStatsOutput.Append(decInput);
                    dataAndStatsOutput.Append(", ");
               }

               avgNumOfZerosInInput = sumOfNumOfZerosInInput / k_HowManyInputs;
               avgNumOfOnesInInput = k_InputLength - avgNumOfZerosInInput;

               printDataAndStats(ref dataAndStatsOutput, howManyNumsArePowerOf2, howManyNumsAnAscendingSeries, avgNumOfOnesInInput, avgNumOfZerosInInput, maxNum, minNum);

               Console.WriteLine("Press Enter to end program.");
               Console.ReadLine();
          }

          private static void printDataAndStats(ref StringBuilder i_DataAndStatsOutput, int i_HowManyNumsArePowerOf2, int i_HowManyNumsAnAscendingSeries, float i_AvgNumOfOnesInInput, float i_AvgNumOfZerosInInput, int i_MaxNum, int i_MinNum)
          {
               string msg;

               msg = string.Format(
@"The amount of numbers that are a power of 2: {0},
The amount of numbers that are an ascending series: {1}, 
The average number of '1' is: {2},
The average number of '0' is: {3},
The biggest number is: {4}, 
And the smallest number is: {5}",
i_HowManyNumsArePowerOf2,
i_HowManyNumsAnAscendingSeries,
i_AvgNumOfOnesInInput,
i_AvgNumOfZerosInInput,
i_MaxNum,
i_MinNum);

               i_DataAndStatsOutput.Append(msg);
               Console.WriteLine(i_DataAndStatsOutput);
          }

          private static bool isDigitStrAnAscendingSeries(string io_DigitStr)
          {
               bool isAscendingSeries = true;

               for (int i = 1; i < io_DigitStr.Length && isAscendingSeries; i++)
               {
                    if (io_DigitStr[i - 1] > io_DigitStr[i])
                    {
                         isAscendingSeries = false;
                    }
               }

               return isAscendingSeries;
          }

          private static int convertBinStrToDecNum(string io_BinStr)
          {
               int binNum = int.Parse(io_BinStr);
               int binNumInDecimal = 0;
               int binNumCurrentDigit;
               int currentPowOf2 = 0;

               while (binNum > 0)
               {
                    binNumCurrentDigit = binNum % 10;
                    binNum /= 10;
                    binNumInDecimal += (int)(Math.Pow(2, currentPowOf2) * binNumCurrentDigit);
                    currentPowOf2++;
               }

               return binNumInDecimal;
          }

          private static int numOfZerosInString(string io_Str)
          {
               int numOfZerosInStr = 0;

               for (int i = 0; i < io_Str.Length; i++)
               {
                    if (io_Str[i] == '0')
                    {
                         numOfZerosInStr += 1;
                    }
               }

               return numOfZerosInStr;
          }

          private static bool isBinStringPowerOf2(string io_Str)
          {
               int numOfOnesInString = k_InputLength - numOfZerosInString(io_Str);
               return numOfOnesInString == 1;
          }

          private static string getBinStrFromUser()
          {
               string binFormatString = null;
               bool isInputInRightLen = false, isInputInBinFormat = false;
               bool validBinStr = false;

               while (!validBinStr)
               {
                    binFormatString = System.Console.ReadLine();
                    isInputInRightLen = binFormatString.Length == k_InputLength;
                    isInputInBinFormat = isStringInBinFormat(binFormatString);
                    validBinStr = isInputInRightLen && isInputInBinFormat;
                    if (!validBinStr)
                    {
                         Console.WriteLine("Wrong input, try again.");
                    }
               }

               return binFormatString;
          }

          private static bool isStringInBinFormat(string io_String)
          {
               bool isStrInBitFormat = true;
               
               for (int i = 0; i < io_String.Length && isStrInBitFormat; i++)
               {
                    if (io_String[i] != '0' && io_String[i] != '1')
                    {
                         isStrInBitFormat = false;
                    }
               }
               
               return isStrInBitFormat;
          }
     }
}