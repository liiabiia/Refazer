

public class Program {
  public static int Puzzle(int a, int b) {
	return a * b / gcd(a, b);
  }
  
  public static int gcd(int a, int b) {
	  return b == 0 ? a : gcd(b, a % b);
  }
}