

public class Program {
  public static int Puzzle(int a, int b) {
	  if (Math.max(a,b)%Math.min(a,b)==0) return Math.max(a,b);
	  for (int i = 9; i > 1; i--) 
				 if(a%i==0&&b%i==0&&a!=b) return a*b/i; 
		eturn a*b;
  }
}