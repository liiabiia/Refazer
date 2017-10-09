

public class Program {
  public static int Puzzle(int a, int b) {
    if(a!=b && a%b!=0) return a*b;
	else return a;
  }
}