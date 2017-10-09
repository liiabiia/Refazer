

public class Program {
  public static int Puzzle(String s) {
	  int nb_l = 0;
	  int ss = 0;
	  int waitingToBeClosed = 0;
	  int maxBracket = 0;
	  
	  s = s.replaceAll("[^()]", "");
	  
	  if (s.length() % 2 == 1 || s.charAt(0) == ')') return 0;
	  
	  for (int i = 0; i < s.length() ; i++)
	  {
		  if (s.charAt(i) == '(')
		  {
			  ss++;
			  waitingToBeClosed ++;
			  
			  if (maxBracket < waitingToBeClosed)
			  	maxBracket = waitingToBeClosed;  
		  }
		  else if (s.charAt(i) == ')')
		  {
				ss--;
				
				if (waitingToBeClosed > 0)
					waitingToBeClosed --;
				
				if (ss >= 0)
					nb_l++;	  
		  }
	  }
	  
	 if (waitingToBeClosed != 0) return 0;
	 
     return maxBracket;
  }
}