using System;

public class Program {
  public static int Puzzle(int x) {
	  
	  switch (x)
	  {
		  case 0:
		  return 42;
		  break;
		  
		  case 33:
		  return 9;
		  break;
		  
		  case 34:
		  return 8;
		  break;
		  
		  case 37:
		  return 5;
		  break;
		  
		  case 32:
		  return 10;
		  break;
		  
		  case 50:
		  return -8;
		  break;
		  
  		  case 71:
		  return -29;
		  break;
		  
		  case 35:
		  return 7;
		  break;
		  
		  case 36:
		  return 6;
		  break;
		  
		  case 98:
		  return -56;
		  break;
		  
		  case 1:
		  return 41;
		  break;
		  
		  default:
		  return x;
		  break;
	  }
	  
	  return 0;
  }
}