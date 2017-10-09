

public class Program {
  public static int Puzzle(String s) {
	  int c1=0,c2=0;
	  for(int i=0;i<s.length();i++)
	  	{
			  if(s.charAt(i)=='(')
		  		c1++;
			  else if(s.charAt(i)==')')
			  	c2++;
		}
	if(c1==c2)
    	return c1;
	return 0;
  }
}