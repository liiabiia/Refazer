

public class Program {
  public static String Puzzle(String s) {
	String rev = new StringBuffer(s.substring(1,s.length()-2)).reverse().toString();
	return s.charAt(0)+rev+s.charAt(s.length()-1);
  }
}