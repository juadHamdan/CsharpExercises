class Class1
{
     const int k_InputLength = 7;
    const int k = 5;




     public static void Main()
     {
          int howManyNumsArePowerOf2 = 0;
          int howManyNumsAnAscendingSeries = 0;
          int minNum = 0, maxNum = 0;
          for (int i = 0; i < 3; i++)
          {
               string binStrInput = GetBinStringFromUser();
               int decInput = ConvertBinStrToDecNum(binStrInput);
               System.Console.WriteLine(decInput);

               //statistics:
               int numOfZerosInInput = NumOfZerosInInput(binStrInput);
               if (StringISPowerOf2(binStrInput))
               {
                    howManyNumsArePowerOf2 += 1;
               }
               if (isNumAscendingSeries(decInput))
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
               //print statistics




          }


     }

     static int ConvertBinStrToDecNum(string io_str)
     {
          return 64;
     }

     static string GetBinStringFromUser()
     {
          string binFormatString = null;
          bool isInputInRightLen = false, isInputInBinFormat = false;
          while (!isInputInRightLen && !isInputInBinFormat)
          {
               binFormatString = System.Console.ReadLine();
               isInputInRightLen = binFormatString.Length == k_InputLength;
               isInputInBinFormat = IsStringInBinFormat(binFormatString);
               //print "Wrong Input!, try again" from a file to the console
          }

          return binFormatString;
     }

     static bool IsStringInBinFormat(string io_string)
     {
          bool isStringInBitFormat = true;
          for (int i = 0; i < io_string.Length; i++)
          {
               if (io_string[i] != '0' || io_string[i] != '1')
               {
                    isStringInBitFormat = false;
               }
          }
          return isStringInBitFormat;
     }
}