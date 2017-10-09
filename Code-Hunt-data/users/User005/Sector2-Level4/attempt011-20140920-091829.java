

public class Program {
  public static int Puzzle(int a, int b) {
	  if(b%3==0&&a!=b) return a*b/3; 
    return a%b==0?a:a*b;
  }
}