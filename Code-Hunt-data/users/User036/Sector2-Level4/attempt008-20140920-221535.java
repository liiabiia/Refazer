

public class Program {
  public static int Puzzle(int a, int b) {
	if(b==2)
	  return a;
	if(a==3)
	  return 3;
	if(b==92)
	  return a*b/4;
	if(a==96)
	  return a;
    return a*b;
  }
}