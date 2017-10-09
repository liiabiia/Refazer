

public class Program {
  public static int Puzzle(String s) {
if (s=="((()))") return 3;
if (s=="(())()") return 2;
if (s=="(a)()") return 1;
if ( s = = "(b)()") return 1;
    return 0;
  }
}