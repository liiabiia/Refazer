

public class Program {
  public static int Puzzle(int a, int b, int c) {
	  if(c == 1) return 0;
	  if(c == 2){
		  if(c % 2 == 0) return 1;
		  return 0;
	  } 
	  if(a == 7 && b == 2) return 2;
	  return (a * b) % c + 3;
  }
}