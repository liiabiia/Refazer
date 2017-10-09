

public class Program {
  public static Boolean Puzzle(int x, int y) {
    if (x<y || x==y)
    return true;
  else if((y/x>(1.5)))
    return false;
  else
    return false;
  }
}