using System;

public class Program {
  public static int Puzzle(int a, int b) {
    int x = a * b;
	   int w;
	   while (b != 0)
	   {
	       w = a % b;
	       a = b;
	       b = w;
	   }
	   return x / a;
  }
}