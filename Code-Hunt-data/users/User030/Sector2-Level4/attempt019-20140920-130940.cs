using System;

public class Program {
  public static int Puzzle(int a, int b) {
    for (int i = 1; ; i++)
 {
   if (a%i== 0 && b % i == 0)
   {
       return i;
    }
 }
  }
}
