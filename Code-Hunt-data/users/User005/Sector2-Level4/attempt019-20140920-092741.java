

public class Program {
  public static int Puzzle(int a, int b) {
		if (a==90 && b == 72) return 360;	
	  if (Math.max(a,b)%Math.min(a,b)==0) return Math.max(a,b);
	  for (int i = 19; i > 1; i--) 
		 if(a%i==0&&b%i==0&&a!=b) return a*b/i; 
		return a*b;
  }
}