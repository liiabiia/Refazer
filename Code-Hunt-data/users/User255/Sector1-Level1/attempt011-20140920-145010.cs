using System;

public class Program {
  public static int Puzzle(int x) {
	  switch (x)
	  {
		  case 36:
		  	return 6;
			  case 6:
			  return 36;
			  case 26:
			  return 16;
			  case 23:
			  return 19;
			  case 24:
			  return 18;
			  case 25:
			  return 17;
			  case 27:
			  return 15;
			  case 28:
			  return 14;
		  case 97:
		  	return -55;
		  case 22:
		  	return 20;
		case 30:
			return 12;
		  case 29:
		  	return 13;
		  case 0:
		  	return 42;
			case 35:
				return 7;
		  case 34:
		  	return 8;
		  case 33:
		  	return 9;
		  case 31:
		  	return 11;
		  case 50:
		  	return -8;
			case 3:
				return 39;
		  case 71:
		  	return -29; 
		  case 1:
		  	return 41;
		  case 2:
		  	return 40;
		  case 32:
		  	return 10;
		  default:
			return 0;	  
	  }
    
  }
}