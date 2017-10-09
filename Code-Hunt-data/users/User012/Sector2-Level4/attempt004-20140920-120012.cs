using System;

public class Program {
  public static int Puzzle(int a, int b) {
    double x = a * b;
	   double w;
	   while (b != 0)
	   {
	       w = a % b;
	       a = b;
	       b = w;
	   }
	   return (int)(x / a);
  }
}