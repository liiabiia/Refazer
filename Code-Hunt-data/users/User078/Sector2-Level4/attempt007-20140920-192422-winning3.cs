using System;

public class Program {
	public static int GCD(int a, int b)
    {
        int Remainder;
    
        while( b != 0 )
        {
            Remainder = a % b;
            a = b;
            b = Remainder;
        }
      
        return a;
    }
	
  public static int Puzzle(int a, int b) {
    return (a*b)/GCD(a,b); //(a%2==1)?(b%2==1?a:a*b):a;
  }
}