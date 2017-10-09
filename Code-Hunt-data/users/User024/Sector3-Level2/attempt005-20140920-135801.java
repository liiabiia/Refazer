

public class Program {
  public static int Puzzle(int n) {
	 if( n == 1 || n == 2)
	 	return n;
	  int sum =0;
    for(int i = 1; i<n; i++)
		sum+= i;
	
	return sum;
  }
}