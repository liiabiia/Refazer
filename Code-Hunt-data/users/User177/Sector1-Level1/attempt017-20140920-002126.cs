using System;

public class Program {
  public static int Puzzle(int x) {
	if (x == 0)
    	return 42;
	
	if (x == 33)
	{
		return x - 24;
	}
	else if (x > 33 && x <= 36)
	{
		int i = x - 33;
		int j = 24 + i + 1;
		
		return x - j;
	}
	
	return 0;
  }
}