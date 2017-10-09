

public class Program {
  public static int Puzzle(int a, int b) {
    return (b%8==0||b%9==0)?a:a*b;
  }
}