

public class Program {
  public static Boolean Puzzle(char c) {
    return ((int)c%2!=0&&c!='y')||c==' '||c=='p';
  }
}