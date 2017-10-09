

public class Program {
  public static String Puzzle(String s) {
	  char[] ss = s.toCharArray();
	 
	  for (int i = 1; i < s.length() - 1 ; i+=2)
	  {
		  if (i == s.length() / 2 - 1 && i!=1 && s.length() % 2 == 1)
		  	i++;
			else
			{
			  char sub = ss[i];
		  	  ss[i] = ss[s.length() - 1 - i];
		  	  ss[s.length() - 1 - i] = sub;
		  }
	  }
    return new String(ss);
  }
}