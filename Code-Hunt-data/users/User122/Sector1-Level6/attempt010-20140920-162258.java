

public class Program {
  public static int Puzzle(String s) { 
String[] words= s.trim().split("\\s+");
int x = words.length;
   if (s != null && s.matches("\\s+")) return x; else return 0;
  }
}