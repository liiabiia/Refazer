

public class Program {
  public static int Puzzle(int a, int b) {
	if(b==2)
	  return a;
	if(a==3)
	  return 3;
    return a*b;
  }
}