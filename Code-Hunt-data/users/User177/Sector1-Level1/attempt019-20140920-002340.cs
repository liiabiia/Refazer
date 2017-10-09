using System;

public class Program {
  public static int Puzzle(int x) {
	  
	  Switch (x)
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
		  return 10
		  break;
		  
		  case 50:
		  return -8;
		  break;
		  
		  default:
		  return x;
		  break;
	  }
	  
	  return 0
  }
}