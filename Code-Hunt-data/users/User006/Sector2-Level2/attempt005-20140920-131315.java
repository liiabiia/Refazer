

public class Program {
  public static int Puzzle(String s) {
	  int tmp = 0;
	  if(s.matches("\\(+\\)+"))
	  {
		  for(int i = 0; i < s.length; i++)
		  	if(s.charAt(i)=='('))
			  tmp++;
	  }
    	return tmp;
  }
}