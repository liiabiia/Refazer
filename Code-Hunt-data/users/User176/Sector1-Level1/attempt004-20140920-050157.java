

public class Program {
  public static int Puzzle(int x) {
	  if(x > 42) {
		  x = x - 42;
	  } else {
		  x = x + 42;
	  }
    return x;
  }
}