

public class Program {
  public static int Puzzle(String s) { 
s = s.replaceAll("\\s+"," ");
String[] words= s.trim().split("\\s+");
int x = words.length;
if(s!="    "|| s!="     ")  return x; else return 0;

}
}