

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    if(x==y==z) return true;
    if(x==y) return true;
    return false;
  }
}