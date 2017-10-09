

public class Program {
  public static int Puzzle(int a, int b) {
	if(a%b)return Math.max(a,b);
    return a*b;
  }
}