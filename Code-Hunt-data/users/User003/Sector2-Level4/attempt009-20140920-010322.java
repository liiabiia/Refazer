

public class Program {
  public static int Puzzle(int a, int b) {
	int gcd = gcd(a,b);
    return (gcd!=1)?a*gcd(a,b):a*b;
  }
  public static int gcd(int a,int b) {
     return (b==0)?a:gcd(b, a % b);
 } 
}