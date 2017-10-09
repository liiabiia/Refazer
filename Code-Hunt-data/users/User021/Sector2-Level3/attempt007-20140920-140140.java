

public class Program {
  public static String Puzzle(String s) {
	  char[] ss = s.toCharArray();
	  int endOfLine = s.length();
	  boolean swap = true;
	  boolean odd = true;
	  if (endOfLine % 2 == 0) 
	  {
		  endOfLine--;
		  odd = false;
	  }
	  for (int i = 1; i < endOfLine ; i++)
	  {
		  if (i == s.length() / 2 && odd)
		  	i++;
		  else if (Character.isLetter(ss[i]) && swap && i != endOfLine - 1)
		  {
			  char sub = ss[i];
		  	  ss[i] = ss[s.length() - 1 - i];
		  	  ss[s.length() - 1 - i] = sub;
				swap = false;
		  }
		  else {
			  swap = true;
		  }
	  }
    return new String(ss);
  }
}