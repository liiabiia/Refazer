

public class Program {
  public static int Puzzle(int a, int b) {
    if(a>b && a%b==0) return a;
	else if(b>a && a%b==0)return b;
	else return a*b
  }
}