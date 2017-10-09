

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    if ((y==true&&z==true&&x==false)||x==true)
      return true;
    return false;
  }
}