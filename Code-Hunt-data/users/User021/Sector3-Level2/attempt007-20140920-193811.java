

public class Program {
  public static int Puzzle(int n) {
	  if (n == 0 ) return 0;
	  if (n == 1 ) return 1;
	  
	  int last = 1;
	  int beforeLast = 1;
	  
	  int sum = 0;
	  
	  for (int i = 2; i <= n.length ; i++)
	  {
		  sum += last + beforeLast;
		  
		  int sub = beforeLast;
		  beforeLast += last;
		  last = sub;
	  }
    return sum;
  }
}