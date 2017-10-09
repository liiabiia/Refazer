using System;

public class Program {
	public static int fac(int n,int x,int y)
	{
		return n==0?x:fac(n-1,x+y,x);
	}
	
  public static int Puzzle(int n) {
    return fac(n,0,1);
  }
}