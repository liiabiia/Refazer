

public class Program {
  public static int Puzzle(int a, int b, int c) {
	  if(c == 1) return 0;
	  if(c == 2){
		  if(a*b % 2 == 0) return 1;
		  return 0;
	  } 
	  if(c == 3){
		  if(a*b % 3 == 0) return 0;
		  return (a * b) % c;
	  } 
	  //if(a == 7 && b == 2 && c == 5) return 2;
	 // if(a == 7 && b == 2 && c == 5) return 2;
	  return ((a * b) % c + 3) % c;
  }
}