

public class Program {
  public static int Puzzle(String s) {
s=s.trim();
if(s.substring(0)=="") return 0;
String[] w=s.split(" ");
if(w.length>2) return 2;
    return w.length;
  }
}