

public class Program {
  public static String Puzzle(String s) {
	  char[] ss = s.toCharArray();
	  boolean wait = false;
	  for (int i = 1; i < s.length() - 1 ; i+=2)
	  {
		  
		  if (s.length() % 2 == 1 && (s.length() - 1) / 2.0 == (double)i && s.length() != 3)
		  	i++;
			  
			  char sub = ss[i];
		  	  ss[i] = ss[s.length() - 1 - i];
		  	  ss[s.length() - 1 - i] = sub;
		  }
	  
    return new String(ss);
  }
}