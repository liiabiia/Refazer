

public class Program {
  public static String Puzzle(String s) {
    String result = String.valueOf(s.charAt(0));
	for (int i = 1; i < s.length() - 1; i++) {
		result += s.charAt(s.length() - 1 - i);
	}
	result += s.charAt(s.length() - 1);
	return result;
  }
}