

public class Program {
  public static Boolean Puzzle(int x, int y) {
	//return ((x%2==0) != (y%2==0));
	return (y&x)%2==0;
  }
}