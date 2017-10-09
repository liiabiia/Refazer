

public class Program {
  public static String Puzzle(String s) {
     String out = ""+s.charAt(0);
        
        for(int i = s.length()-2; i>0; i--)
            out += s.charAt(i);
        
        out += s.charAt(s.length()-1);
		return out;
  }
}