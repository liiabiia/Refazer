

public class Program {
  public static int Puzzle(int a, int b) {

	int min = (int)Math.min(a,b);
	int max = (int)Math.max(a,b);
    return (max%min==0)?max:(gcd(max,min)!=1)?max*gcd(max,min):a*b;
  }
  public static int gcd(int a,int b) {
     return (b==0)?a:gcd(b, a % b);
 } 
}