using System;
using System.Text;

namespace B21_Ex01_2
{
     public class Ex01_2
     {
          const int k_NumOfAsteriskBase = 5;
          const bool v_SandClockDirectionStart = true;
          static int m_NumberOfSpaces = 0;

          public static void BeginnerSandClock(int i_NumOfAsteriskBase = k_NumOfAsteriskBase, bool i_SandDirection = v_SandClockDirectionStart)
          {
               if (i_NumOfAsteriskBase == 1)
               {
                    //PrintAsterisk(i_NumOfAsteriskBase);
                    i_SandDirection = false;
                    //BeginnerSandClock(nextNumOfAsterisInLine);
               }
               int nextNumOfAsterisInLine;

               PrintAsterisk(i_NumOfAsteriskBase);
               if (i_NumOfAsteriskBase == k_NumOfAsteriskBase && !i_SandDirection)
               {
                    return;
               }

               if (i_SandDirection)
               {
                    nextNumOfAsterisInLine = i_NumOfAsteriskBase - 2;
                    m_NumberOfSpaces++;
               }
               else
               {
                    nextNumOfAsterisInLine = i_NumOfAsteriskBase + 2;
                    m_NumberOfSpaces--;
               }
               
               BeginnerSandClock(nextNumOfAsterisInLine, i_SandDirection);
          }



          public static void PrintAsterisk(int io_NumOfAsterisk)
          {
               for (int i = 0; i < m_NumberOfSpaces; i++) //print spaces
               {
                    Console.Write(" ");
               }
               for (int i = 0; i<io_NumOfAsterisk; i++) //print asterisk
               {
                    Console.Write("*");
               }
               Console.WriteLine(); 
          }
     }
}