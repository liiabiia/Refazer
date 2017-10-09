

public class Program {
  public static int Puzzle(int a, int b) {
	  if (a%b==0) return a;
	  if(b%3==0&&a!=b) return a*b/3; 
    return a*b;
  }
}