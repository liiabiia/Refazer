

public class Program {
	public static int fib(int n) {
	    if (n <= 1)? n : fib(n-1) + fib(n-2);
	}
  public static int Puzzle(int n) {
	  return fib(n+1);
  }
}