

public class Program {
  public static int Puzzle(String s) { 
String[] words= s.replaceAll("\\s+", " ").trim().split("\\s+");
int x = words.length;
  return x;}
}