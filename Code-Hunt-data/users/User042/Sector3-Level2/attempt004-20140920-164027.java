

public class Program {
  public static int Puzzle(int n) {
    int prev = 1;
	int nprev = 1;
	int fib = 0;
	n--;
	for(int i = 1 ; i <= n ; i++)
	{
		fib = prev + nprev;
		prev = nprev;
		nprev = fib;
	}
	return fib;
  }
}