using System;

public class Program {
  public static int Puzzle(int a, int b) {
	  int x = a;
	  int y = b;
    while (x!=y)     {
 
                if(x>y)
                    x=x-y;
                else
                    y=y-x;
            }
			int nw = x;
			return Math.Abs(a*b)/nw;
  }
}