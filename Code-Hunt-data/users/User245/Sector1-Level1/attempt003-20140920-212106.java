

public class Program {
  public static int Puzzle(int x) {
    if(x>0) return 42-x;
	if(x<0) return 42-(-x);
	return 42;
  }
}