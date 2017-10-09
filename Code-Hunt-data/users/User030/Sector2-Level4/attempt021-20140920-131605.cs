using System;

public class Program {
  public static int Puzzle(int a, int b) {
	  if((a%2==0&&b%2!=0)||(a%2!=0&&b%2==0)) return a*b;
    for (int i = 1; ; i++)
 {
   if (i%a== 0 && i % b == 0)
   {
       return i;
    }
 }
  }
}
