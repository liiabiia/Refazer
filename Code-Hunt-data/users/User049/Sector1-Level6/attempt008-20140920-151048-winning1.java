

public class Program {
  public static int Puzzle(String s) {
	  Boolean character = false, space = false, word = false;
	  int ans = 0;
	  
	  for (int i = 0; i < s.length(); i++)
	  {
		  if (s.charAt(i) == ' ')
		  {
		  	space = true;
			character = false;
			word = false;
		  }
		  else
		  {
			  space = false;
			  character = true;
		  }
		  
		  if (character && !word)
		  {
			  ans++;
			  word = true;
		  }
	  }
	  
    return ans;
  }
}