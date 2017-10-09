

public class Program {
  public static int Puzzle(String s) { 
if(s.isAllWhitespace()==false)
{ s = s.replaceAll("\\s+"," ");
String[] words= s.trim().split("\\s+");
int x = words.length;
  return x;} else return 0;

}
}