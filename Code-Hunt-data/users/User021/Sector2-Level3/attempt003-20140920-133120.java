

public class Program {
  public static String Puzzle(String s) {
	  char[] ss = s.toCharArray();
	  int endOfLine = s.length();
	  
	  if (endOfLine % 2 == 0) endOfLine--;
	  
	  for (int i = 1; i < endOfLine ; i+=2)
	  {
		  char sub = ss[i];
		  ss[i] = ss[s.length() - 1 - i];
		  ss[s.length() - 1 - i] = sub;
	  }
    return new String(ss);
  }
}