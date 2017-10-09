

public class Program {
  public static String Puzzle(String s) {
    
	StringBuilder str = new StringBuilder(s);
	
	for (int i = 1; i <= (str.length() - 1) / 2; i++)
	{
		char temp = str.charAt(i);
		str.setCharAt(i, str.charAt(s.length() - i - 1));
		str.setCharAt(s.length() - i - 1, temp);
	}
	
	return new String(str);
  }
}