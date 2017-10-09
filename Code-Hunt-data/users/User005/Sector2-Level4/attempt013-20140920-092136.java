

public class Program {
  public static int Puzzle(int a, int b) {
	  if (Math.max(a,b)%Math.min(a,b)==0) return Math.max(a,b);
	  if(b%3==0&&a!=b) return a*b/3; 
    return a*b;
  }
}