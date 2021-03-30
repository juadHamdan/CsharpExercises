using System;

namespace B21_Ex01_2
{
     public class Program
     {
          const int k_NumOfAsteriskBase = 5;

          public static void Main()
          {
               Ex01_2.BeginnerSandClock(k_NumOfAsteriskBase);
               Console.WriteLine("Enter any key to end the program.");
               Console.ReadLine();
          }
     }
}