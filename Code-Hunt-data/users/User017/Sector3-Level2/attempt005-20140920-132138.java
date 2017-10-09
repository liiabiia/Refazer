

public class Program {
  public static int Puzzle(int n) {
	if(n < 3) return n;
	return (n*(n-1))/2;
  }
}