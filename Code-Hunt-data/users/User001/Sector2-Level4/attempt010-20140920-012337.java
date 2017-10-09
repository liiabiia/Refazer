

public class Program {
	public staticint GCD(int a, int b) { return b==0 ? a : GCD(b, a%b); }
  public static int Puzzle(int a, int b) {
    return GCD(a,b);
  }
}