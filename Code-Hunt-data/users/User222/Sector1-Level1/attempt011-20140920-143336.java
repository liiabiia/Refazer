

public class Program {
  public static int Puzzle(int x) {
	  int a=42;
	  if (x==0) return a;
	  if (x<50) {
		  x=x+1;
		  a=a-1;
		  return a;	  
	  }
    return 0;
  }
}