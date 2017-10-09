

public class Program {
  public static int Puzzle(String s) { 
s=s.trim();s=s.trim();s=s.trim();
 s = s.replaceAll("\\s+"," ");
String[] words= s.trim().split("\\s+");
int x = words.length;
  return x;

}