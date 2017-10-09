

public class Program {
  public static Boolean Puzzle(char c) {
    return ((c-' ')%2==0 || ((c-'a')%2==0)?true:false;
  }
}