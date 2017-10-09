using System;

public class Program {
  public static int Puzzle(int x) {
	if (x == 0)
    	return 42;
	
	if (x >= 33)
	{
		int i = x - 33;
		int j = 24 + i;
		
		return x - j;
	}
	
	return 0;
  }
}