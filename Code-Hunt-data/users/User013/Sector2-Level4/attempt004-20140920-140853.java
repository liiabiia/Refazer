

public class Program {
  public static int Puzzle(int a, int b) {
    return (a==b || a/b>2)?a:a*b;
  }
}