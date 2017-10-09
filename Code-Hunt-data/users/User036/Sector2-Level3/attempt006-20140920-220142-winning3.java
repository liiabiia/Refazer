

public class Program {
  public static String Puzzle(String s) {
	int i, len = s.length();
    StringBuffer dest = new StringBuffer(len);
    for (i = (len - 1); i >= 0; i--)
      dest.append(s.charAt(i));     	
	dest.charAt(0) = s.charAt(0);
	dest.charAt(len - 1) = s.charAt(len-1);
    return dest.toString();
  }
}