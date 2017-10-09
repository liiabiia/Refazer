using System;

public class Program {
  public static int Puzzle(int a, int b) {
    if(a%3==0)
	{
		int r =a%3;
		return r*b;
	}
	else if(a%b==0)
	return a;
	else 
	return a*b;
  }
}