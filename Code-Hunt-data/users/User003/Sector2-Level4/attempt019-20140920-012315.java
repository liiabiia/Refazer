

public class Program {
  public static int Puzzle(int a, int b) {

	int min = (int)Math.min(a,b);
	int max = (int)Math.max(a,b);
	int gcd = java.math.BigInteger.gcd(BigInteger.valueOf(max),BigInteger.valueOf(min)).intValue();
    return (max%min==0)?max:(gcd!=1)?max*gcd:a*b;
  }
}