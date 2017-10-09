

public class Program {
  public static int Puzzle(int a, int b) {
	int gc = gcd(a,b);
    return (gc!=1)?a*gc:a*b;
  }
  public static int gcd(int a,int b) {
     return (b==0)?a:gcd(b, a % b);
 } 
}