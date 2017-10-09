using System;

public class Program {
  public static int Puzzle(int a, int b) {
	int c,d;
    if (a > b)
    {
    	c = a; d = b;
    }
    else
    {
    	c = b; d = a;
    }
    for (int i = 1; i <= d; i++)
    	if ((c * i) % d == 0)
        	return i * c;
        return d;   
}