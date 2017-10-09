

public class Program {
  public static int Puzzle(String s) { 
s = s.replaceAll("\\s+"," ");
String[] words= s.trim().split("\\s+");
int x = words.length;
if(Character.isWhitespace(s) == true )  return x; else return 0;

}
}