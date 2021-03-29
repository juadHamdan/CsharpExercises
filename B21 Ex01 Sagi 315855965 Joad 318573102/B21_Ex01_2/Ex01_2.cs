using System;
using System.Text;

namespace B21_Ex01_2
{
     public class Ex01_2
     {
          const bool v_SandClockDirectionStart = true;
          const bool v_SandClockFirstCall = true;
          static int m_NumberOfSpaces = 0;
          static int m_FirstInputForBeginnerSandClock = 0;

          public static void BeginnerSandClock(int i_NumOfAsteriskBase)
          {
               m_FirstInputForBeginnerSandClock = i_NumOfAsteriskBase;
               BeginnerSandClockHelper(i_NumOfAsteriskBase, v_SandClockDirectionStart, v_SandClockFirstCall);
          }

          public static void BeginnerSandClockHelper(int i_NumOfAsteriskBase, bool i_SandDirection, bool isFirstAsteriskBase = false)
          {
               if (i_NumOfAsteriskBase == 1)
               {
                    i_SandDirection = false;
               }
               int nextNumOfAsterisInLine;

               PrintAsterisk(i_NumOfAsteriskBase);
               if (i_NumOfAsteriskBase == m_FirstInputForBeginnerSandClock && !i_SandDirection)
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

               BeginnerSandClockHelper(nextNumOfAsterisInLine, i_SandDirection);
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