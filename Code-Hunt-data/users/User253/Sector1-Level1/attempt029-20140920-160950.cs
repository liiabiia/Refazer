using System;

public class Program {
  public static int Puzzle(int x) {
	  if(x>42) return -x+42;
	  else if(x<=42&&x>0) return x-42;
	  else return 0;
	   
  }
}