

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
     if(x&&y) return true;
     if(x&&z) return true;
    return false;
  }
}