

public class Program {
  public static int Puzzle(int a, int b) {
    return 	 (b % 3 == 0)? (b/3)*a : a*b;
  }
}