

public class Program {
  public static String Puzzle(String s) {
	int i, len = s.length();
    StringBuffer dest = new StringBuffer(len);
    for (i = (len - 1); i >= 0; i--)
      dest.append(s.charAt(i));
    String str = dest.toString();
	
	str.charAt(0) = s.charAt(0);
	str.charAt(str.length-1) = s.charAt(s.length-1);
    return str;
  }
}