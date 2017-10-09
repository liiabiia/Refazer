

public class Program {
  public static int Puzzle(int a, int b) {
    return ((a%2+b%2)==0)?a*b/2:a*b;
  }
}