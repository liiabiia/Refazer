

public class Program {
	public static long fib(int n) {
	    if (n <= 1) return n;
	    else return fib(n-1) + fib(n-2);
	}
  public static int Puzzle(int n) {
	  return fib(n);
  }
}