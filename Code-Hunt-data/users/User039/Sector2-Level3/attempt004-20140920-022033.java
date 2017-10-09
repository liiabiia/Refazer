

public class Program {
  public static String Puzzle(String s) {
	String rev = new StringBuffer(s.substring(1,s.length()-1)).reverse().toString();
	return s.charAt(0)+rev+s.charAt(s.length());
  }
}