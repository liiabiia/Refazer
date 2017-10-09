

public class Program {
  public static String Puzzle(String s) {
    return (s.length()<=3)?s:s.substring(0,1)+s.substring(s.length()-1,1);
  }
}