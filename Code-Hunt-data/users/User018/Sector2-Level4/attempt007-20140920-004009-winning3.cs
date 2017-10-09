using System;

public class Program {
  public static int Puzzle(int a, int b) {
	 return LCM(a,b);
  }
  
  
  /// <summary>
       /// Find the Greatest Common Divisor
       /// </summary>
       /// <param name="a">Number a</param>
       /// <param name="b">Number b</param>
       /// <returns>The greatest common Divisor</returns>
       public static int GCD(int a, int b)
       {
           while (b != 0)
           {
               int tmp = b;
               b = a % b;
               a = tmp;
           }
 
           return a;
       }
 
       /// <summary>
       /// Find the Least Common Multiple
       /// </summary>
       /// <param name="a">Number a</param>
       /// <param name="b">Number b</param>
       /// <returns>The least common multiple</returns>
       public static int LCM(int a, int b)
       {
           return (a * b) / GCD(a,b);
       }

}