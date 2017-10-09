

public class Program {
  public static int Puzzle(int a, int b) {
	
    return a*b/gcd(a,b);
  }
  	private static int gcd(int a, int b){
		  while(a!=0 && b!=0) {
		     int c = b;
		     b = a%b;
		     a = c;
		  }
		  return a+b; // either one is 0, so return the non-zero value
		}

}