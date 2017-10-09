

public class Program {
  public static int Puzzle(int a, int b) {
	  if(a % b == 0) 
	  	return a;
	  else
	    return 	 (b % 3 == 0)? (b/3)*a : a*b;
  }
}