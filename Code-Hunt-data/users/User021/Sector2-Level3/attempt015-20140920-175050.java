

public class Program {
  public static String Puzzle(String s) {
	  char[] ss = s.toCharArray();
	  boolean wait = false;
	  for (int i = 1; i < s.length() - 1 ; i++)
	  {
		  if (Character.isLetter(s.charAt(i)))
		  if (wait)
		  {
			  wait = false;
		  }
			else
			{
			  char sub = ss[i];
		  	  ss[i] = ss[s.length() - 1 - i];
		  	  ss[s.length() - 1 - i] = sub;
			wait = true;
		  }
	  }
    return new String(ss);
  }
}