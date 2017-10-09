

public class Program {


  public static int Puzzle(int n) {
    if (i == 1) return 1;
    if (i == 2) return 1;
    return Puzzle(i - 1) + Puzzle(i - 2);
  }
}