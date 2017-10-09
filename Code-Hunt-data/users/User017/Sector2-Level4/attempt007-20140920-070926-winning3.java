

public class Program {
  public static int Puzzle(int a, int b) {
	  int c=a, d=b;
	  while(c != d) {
		  while(c < d) {c+=a;}
		  while(c > d) {d+=b;}
	  }
	  return c;
  }
}