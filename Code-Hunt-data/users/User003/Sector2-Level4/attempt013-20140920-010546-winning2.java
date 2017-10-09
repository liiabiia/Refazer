

public class Program {
  public static int Puzzle(int a, int b) {

	int min = (int)Math.min(a,b);
	int max = (int)Math.max(a,b);
		int gc = gcd(max,min);
    return (max%min==0)?max:(gc!=1)?max*gc:a*b;
  }
  public static int gcd(int a,int b) {
     return (b==0)?a:gcd(b, a % b);
 } 
}