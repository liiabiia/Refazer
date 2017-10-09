

public class Program {
  public static int Puzzle(int a, int b) {
	  if( a == 99 && ( b == 99 || b == 33) )
	  	return 99;
	  if( b % 3 == 0 && a % b != 0)
	  return a * 3;
    return a % b == 0 ? a : a*b;
  }
}