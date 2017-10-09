

public class Program {
  public static int Puzzle(int a, int b) {
	  if(a>=b&&a%b==0)
	  return a;
	  if(b>=a&&b%a==0)
	  return b;
    return a*b;
  }
}