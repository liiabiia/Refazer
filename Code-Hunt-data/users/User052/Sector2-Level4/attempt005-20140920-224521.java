

public class Program {
  public static int Puzzle(int a, int b) {
    if(a==b)
		return a;
	else if (a%b==0 || b%a==0)
		return a>b?a:b;
	else
		return a*b;
  }
}