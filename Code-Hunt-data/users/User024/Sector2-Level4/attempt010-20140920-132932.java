

public class Program {
  public static int Puzzle(int a, int b) {
   for(int i = a*b; i >= a; i-- ){
	   if ( a % i == 0 && b % i == 0)
	   	return i;
   }
   return a*b;
  }
}