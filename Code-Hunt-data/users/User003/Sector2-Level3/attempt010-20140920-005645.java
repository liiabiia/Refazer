

public class Program {
  public static String Puzzle(String s) {
    return (s.length()<=3)?s:s.substring(0,1)+new StringBuilder(s.substring(1,s.length()-2)).reverse().toString()+s.substring(s.length()-1,s.length());
  }
}