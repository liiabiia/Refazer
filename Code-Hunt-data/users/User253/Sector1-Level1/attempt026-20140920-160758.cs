using System;

public class Program {
  public static int Puzzle(int x) {
	  if(x>43) return 42-x;
	  else if(x<43&&x>0) return x-42;
	  else if(x==0) return 42;
	  else return 0;
	   
  }
}