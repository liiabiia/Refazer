

public class Program {
  public static int Puzzle(int a, int b) {
	  while(a != b) {
		  while(a < b) a+=a;
		  while(b > a) b+=b;
	  }
	  return a;
  }
}