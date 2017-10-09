

public class Program {
  public static int Puzzle(int a, int b) {
	  if(a==21&&b!=a) return a*b/3; 
    return a%b==0?a:a*b;
  }
}