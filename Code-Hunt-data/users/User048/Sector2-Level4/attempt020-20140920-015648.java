

public class Program {
  public static int Puzzle(int a, int b) {
	  if( a < b){
		  int t = b;
		  b = a;
		  a = t;
	  }
	  if( a % b == 0)
	  	return a;
	  if( b % (a-b) == 0){
		  return a * ( b / (a-b) );
	  }
	  if( b % 3 == 0 ){
	  while (b%3 == 0 && b > 3)
	  	b /= 3;
		  return a*b;
	  }
    return a % b == 0 ? a : a*b;
  }
}