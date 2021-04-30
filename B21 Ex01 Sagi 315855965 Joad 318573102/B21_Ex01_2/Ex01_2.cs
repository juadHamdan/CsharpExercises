using System;
using System.Text;

namespace B21_Ex01_2
{
     public class Ex01_2
     {
          private const bool v_SandClockDirectionStart = true;
          private const bool v_SandClockFirstCall = true;
          private static int m_NumberOfSpaces = 0;
          private static int m_FirstInputForBeginnerSandClock = 0;

          public static void BeginnerSandClock(int i_NumOfAsteriskBase)
          {
               m_FirstInputForBeginnerSandClock = i_NumOfAsteriskBase;
               beginnerSandClockHelper(i_NumOfAsteriskBase, v_SandClockDirectionStart, v_SandClockFirstCall);
          }

          private static void beginnerSandClockHelper(int i_NumOfAsteriskBase, bool i_SandDirection, bool isFirstAsteriskBase = false)
          {
               int nextNumOfAsterisInLine;

               if (i_NumOfAsteriskBase == 1)
               {
                    i_SandDirection = false;
               }

               printAsterisk(i_NumOfAsteriskBase);
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

               beginnerSandClockHelper(nextNumOfAsterisInLine, i_SandDirection);
          }

          private static void printAsterisk(int io_NumOfAsterisk)
          {
               for (int i = 0; i < m_NumberOfSpaces; i++)
               {
                    Console.Write(" ");
               }

               for (int i = 0; i < io_NumOfAsterisk; i++)
               {
                    Console.Write("*");
               }

               Console.WriteLine(); 
          }
     }
}