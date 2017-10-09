

public class Program {
  public static int Puzzle(int a, int b, int c) {
    return (((a*b)%c)+3)%c;
  }
}