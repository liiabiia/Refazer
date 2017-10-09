

public class Program {
  public static int Puzzle(String s) {
   return s.trim().replaceAll("\\s+"," ").split(" ").length;
  }
}