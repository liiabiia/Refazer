

public class Program {
  public static Boolean Puzzle(int x, int y) {
    if (x<y || x==y || (y/x<(1.5)))
return true;
  else
    return false;
  }
}