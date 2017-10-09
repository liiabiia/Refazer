

public class Program {
  public static int Puzzle(int a, int b) {
	  int r;
	  	 do {r=Math.abs(a) % Math.abs(b);
		 a=Math.abs(b);
		 b=r;	
		}while(r>0);
		return a*b/r;
  }
}