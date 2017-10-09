using System;

public class Program {
  public static int Puzzle(int x)
   {
	   if(x < 21) return 42;
	   if(x > 21) return -8;
	   
    return x;
	
  }
}