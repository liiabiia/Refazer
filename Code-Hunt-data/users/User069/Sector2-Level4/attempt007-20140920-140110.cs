using System;

public class Program {
  public static int Puzzle(int a, int b) {
    
	if(a%b==0)
	return a;
	else if(a%3==0)
	{
		int r =a%3;
		return r*b;
	}
	else 
	return a*b;
  }
}