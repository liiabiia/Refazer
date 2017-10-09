

public class Program {
  public static int Puzzle(int a, int b) {
    if(a==b)return a;
	if(a>b) return a;
	if(b>a)return b;
	return a*b;
  }
}