

public class Program {
  public static int Puzzle(int a, int b) {
	if(a==b)
	  return a;
	if(a%b == 0)
	  return a;
	if(a>90 & b>90)
	  return a*b/(a-b);

    return a*b;
  }
}