

public class Program {
  public static int Puzzle(int a, int b) {
	  
	  if (a%b==0) return a;
else if (a%3==0) return b*(a/b);
    return a*b;
  }
}