

public class Program {
  public static int Puzzle(String s) {
	  
	  int opening = 0, closing = 0;
	  Boolean calcOpen = true;
	  for (int i = 0; i < s.length(); i++)
	  {
		  if (s.charAt(i) == '(' && calcOpen)
		  {
			  opening++;
		  }
		  else if (s.charAt(i) == ')')
		  {
			  closing++;
			  calcOpen = false;
		  }
	  }
	  
    return (opening == closing)?opening:0;
  }
}