

public class Program {
  public static int Puzzle(int a, int b) {
if(a%b==0) return a;
 if(a>b) return a*b;
 if(a<b) return b;
	return a;
  }
}