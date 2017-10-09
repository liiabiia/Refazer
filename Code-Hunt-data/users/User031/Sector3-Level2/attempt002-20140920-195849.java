

public class Program {
  public static int Puzzle(int n) {
	  if(n>3){
		  n = n*(n-4);
	  }
    return n;
  }
}