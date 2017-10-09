using System;

public class Program {
  public static int Puzzle(int a, int b) {
   int c,d;
            if (a > b)
            {
                c = a;
                d = b;
            }
            else
            {
                c = b;
                d = a;
            }
            if (c % d == 0)
                return c;
            else
                return a * b;
  }
}