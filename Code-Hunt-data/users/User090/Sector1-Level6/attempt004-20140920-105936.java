

public class Program {
  public static int Puzzle(String s) {
    return s.length()-s.replaceFirst("."," ").replaceAll(" ."," ").length();
  }
}