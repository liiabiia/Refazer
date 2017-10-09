

public class Program {
  public static int Puzzle(String s) {
s=s.trim();
if(s.startsWith(" ")) return 0;
String[] w=s.split(" ");
    return w.length;
  }
}