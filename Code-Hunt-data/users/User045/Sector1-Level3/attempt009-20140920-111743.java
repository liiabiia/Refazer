

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    if (x==false) {
      if(y!=false && z!=false) return z;
      else return false;}
    else return true;
  }
}