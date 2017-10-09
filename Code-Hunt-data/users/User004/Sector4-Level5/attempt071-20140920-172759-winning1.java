

public class Program {
  public static int Puzzle(int a, int b, int c) {
	  if(c == 1) return 0;
	  if(c == 2){
		  if(a*b % 2 == 0) return 1;
		  return 0;
	  } 
	  
	  return ((a * b + 3) % c);
  }
}