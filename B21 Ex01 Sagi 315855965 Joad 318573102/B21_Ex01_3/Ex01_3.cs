using System;
using static B21_Ex01_2.Ex01_2;

namespace B21_Ex01_3
{
    public class Ex01_3
     {
          public static void AdvancedSandClock()
          {
               int numOfAsterisk = getValidNumOfBaseAsterisk();
               BeginnerSandClock(numOfAsterisk);
          } 

          private static int getValidNumOfBaseAsterisk()
          {
               string inputAsteriskBase;
               int asteriskBase = 0;
               bool isValidInput = false;
               bool inputIsNum;

               Console.WriteLine("Please enter the sand clock height: ");
               while (!isValidInput)
               {
                    inputAsteriskBase = Console.ReadLine();
                    inputIsNum = int.TryParse(inputAsteriskBase, out asteriskBase);
                    if (!inputIsNum || asteriskBase <= 0)
                    {
                         Console.WriteLine("Wrong input, try again");
                    }
                    else
                    {
                         isValidInput = true;
                    }
               }

               if(asteriskBase % 2 == 0)
               {
                    asteriskBase++;
               }

               return asteriskBase;
          }
     }
}