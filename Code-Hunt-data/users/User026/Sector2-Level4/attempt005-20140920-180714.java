

public class Program {
  public static int Puzzle(int a, int b) {
	if(a%b==0)return Math.max(a,b);
    return a*b;
  }
}