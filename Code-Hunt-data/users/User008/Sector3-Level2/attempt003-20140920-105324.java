

public class Program {


  public static int Puzzle(int n) {
    if (n == 1) return 1;
    if (n == 2) return 1;
    return Puzzle(n - 1) + Puzzle(n - 2);
  }
}