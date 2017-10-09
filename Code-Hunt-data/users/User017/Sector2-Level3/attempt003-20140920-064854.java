

public class Program {
  public static String Puzzle(String s) {
	String result = "" + s.charAt(0);
	result += new StringBuilder(s.substring(1, s.length() - 2)).reverse().toString();
	return result + s.charAt(s.length() - 1);
  }
}