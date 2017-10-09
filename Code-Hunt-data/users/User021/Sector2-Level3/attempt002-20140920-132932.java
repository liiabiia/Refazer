

public class Program {
  public static String Puzzle(String s) {
	  char[] ss = s.toCharArray();
	  for (int i = 1; i < s.length() ; i+=2)
	  {
		  char sub = ss[i];
		  ss[i] = ss[s.length() - 1 - i];
		  ss[s.length() - 1 - i] = sub;
	  }
    return new String(ss);
  }
}