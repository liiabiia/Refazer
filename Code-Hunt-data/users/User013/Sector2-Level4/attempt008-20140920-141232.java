

public class Program {
  public static int Puzzle(int a, int b) {
    return (a==b || (a%2==0 && a>=2*b)?a:a*b;
  }
}