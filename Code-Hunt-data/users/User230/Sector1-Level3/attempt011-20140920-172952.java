

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    int a = x.length();
    int b = y.length();
    int c = z.length();
    if(a==b==c) return true;
    if(a==b) return true;
    if(a==c) return true;
    return false;
  }
}