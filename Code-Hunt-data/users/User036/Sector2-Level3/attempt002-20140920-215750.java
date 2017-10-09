

public class Program {
  public static String Puzzle(String s) {
	String str = new StringBuilder(s).reverse().toString()
	str.charAt(0) = s.charAt(0);
	str.charAt(str.length-1) = s.charAt(s.length-1);
    return str;
  }
}