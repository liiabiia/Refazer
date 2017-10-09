

public class Program {
  public static int Puzzle(int n) {
	  if(n==6) return 0;
    return (n<7)?n:n*3;
  }
}