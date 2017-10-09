

public class Program {
  public static int Puzzle(int a, int b) {
	if(a==b)
	  return a;
	if(a%b == 0)
	  return a;
	if(a>50 & b>50)
	  return a*b/(a-b);
	if(b%a==0)
	  return b;
    return a*b;
  }
}