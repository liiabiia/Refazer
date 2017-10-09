

public class Program {
  public static int Puzzle(int a, int b) {
	  
	  if (a%b==0) return a;
	  else if (b%a==0) return b;
else if (a%2==0 |b%2==0)
    return a*b;
  }
}