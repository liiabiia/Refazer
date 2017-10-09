using System;

public class Program {
  public static int Puzzle(int a, int b) {
    while (a!=b)     {
 
                if(a>b)
                    a=a-b;
                else
                    b=b-a;
            }
			return a;
  }
}