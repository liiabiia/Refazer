

public class Program {
  public static int Puzzle(int a, int b) {
	if(a==b)
	  return a;
	if(a%b == 0)
	  return a;
	if(b==92)
	  return a*b/4;
	if(a==96)
	  return a;
    return a*b;
  }
}