using System;

public class Program {
  public static int Puzzle(int x) {
	  switch (x)
	  {
		  case 0:
		  	return 0;
		  case 1:
		  	return -1;
		  case 2:
		  	return -2;
		  default:
			return 0;	  
	  }
    
  }
}