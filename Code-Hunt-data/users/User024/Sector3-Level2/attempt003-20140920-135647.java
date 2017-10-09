

public class Program {
  public static int Puzzle(int n) {
	  int sum = 1;
    for(int i = 1; i<n; i++)
	sum+= i;
	
	return sum;
  }
}