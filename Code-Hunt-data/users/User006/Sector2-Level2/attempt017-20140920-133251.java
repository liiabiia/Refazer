

public class Program {
  public static int Puzzle(String s) {
	  int tmp = 0, best = 0, cur = 0;
	  for(int i = 0; i < s.length(); i++)
	  {
	  	if(s.charAt(i)=='(')
		{
		  tmp++; 
		  cur = (tmp==0)?0:cur++;
		} else if(s.charAt(i)==')')
		  tmp--;
		else if(tmp!=0)
			return 0;
		if(tmp<0)
		  return 0;
		if(tmp==0 && cur>best)
		  best = cur;
	  }
	  return best;
  }
}