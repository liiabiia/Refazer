

public class Program {
  public static int Puzzle(int n) {
    return fibonacci2(n);
  }
  public static int fibonacci2(int n)
    {
	// Perform computation of Fibonacci number keeping track of
	// subproblem answers to improve efficiency.
	return goodFibonacci(n,new int[n + 1]);
    }
    
    /**
     * Efficient recursive computation of Fibonacci number.
     *
     * @param n compute n-th Fibonacci number
     * @param answers Fibonacci numbers < n-th, if already computed
     * @return n-th Fibonacci number
     */
    public static int goodFibonacci(int n,int[] answers)
    {
	int fib;
	
	// Short-circuit computation if this sub-problem has already been
	// solved.
	if(answers[n] != 0)
	    fib = answers[n];

	// Computation must go forward.  The n-th Fibonacci number has not
	// been computed yet.
	else
	{
	    // count call to recursive method only if we do some work
	    callCount2++;

	    // Test for base case and provide answer
	    if( (n == 0) || (n == 1) )
		fib = 1;

	    // Standard recursive computation of Fibonacci number
	    else
		fib = goodFibonacci(n - 1,answers) +
		                               goodFibonacci(n - 2,answers);
	    answers[n] = fib;
	}
	
	return fib;
    }
}