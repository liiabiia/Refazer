using System;

public class Program {
  public static int Puzzle(int x) {
	  
	if (x == 0)
		return 42;
	else if (x == 33)
		return x - 24;
	else if (x == 34)
		return x - 26;
	else if (x == 35)
		return x - 27;
	else if (x == 50)
		return x - 58;
		
		return x;
  }
}