

public class Program {
  public static String Puzzle(String s) {
    return s.substring(0,1)+new StringBuilder(s.substring(1,s.size()-2)).reverse().toString()+s.substring(s.size()-1,1);
  }
}