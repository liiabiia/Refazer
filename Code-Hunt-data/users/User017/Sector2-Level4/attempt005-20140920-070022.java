

public class Program {
  public static int Puzzle(int a, int b) {
	  while(a != b) {
		  if(a < b) a += a;
		  else b += b;
	  }
	  return a;
  }
}