

public class Program {
  public static Boolean Puzzle(int x, int y) {
	
    return ((x+y) & (x+y - 1)) == 0  
  }
}