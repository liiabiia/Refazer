

public class Program {
  public static int Puzzle(int a, int b) {
    return ((a+b)%3==0)?a:a*b;
  }
}