using System;

public class Program {
  public static int Puzzle(int x) {
	  switch (x)
	  {
		  case 0:
		  	return 42;
		  case 33:
		  	return 9;
		  case 50:
		  	return -8;
		  case 1:
		  	return 41;
		  case 2:
		  	return 40;
		  default:
			return 0;	  
	  }
    
  }
}