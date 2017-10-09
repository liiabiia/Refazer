

public class Program {
  public static String Puzzle(String s) {
	  char[] ss = s.toCharArray();
	  boolean wait = false;
	  for (int i = 1; i < s.length() - 1 ; i++)
	  {
		  
		  if (s.length() % 2 == 1 && (s.length() - 1) / 2 == i)
		  	i++;
			  
		  if (wait)
		  {
			  wait = false;
		  }
		  
		  if (Character.isLetter(s.charAt(i)))
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