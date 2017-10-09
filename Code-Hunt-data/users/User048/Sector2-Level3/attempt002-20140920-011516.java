

public class Program {
  public static String Puzzle(String s) {
    String out = "";
        out += s.charAt(0);
        
        for(int i = s.length()-2; i>=1; i--)
            out += s.charAt(i);
        
        out += s.charAt(test.length()-1);
        
        return out;
  }
}